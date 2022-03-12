# -*- coding: utf-8 -*-
import os

import pandas as pd
import re
from mysql.connector import Error
import mysql.connector as connection
from DBconnection import DBconnection

from tasks_methods import check_unprocessed_files_count

def database_processing_image():
    if not check_unprocessed_files_count(
            os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_image.csv")):
        directory = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/image"))
        for file in os.listdir(directory):
            file_directory = os.path.join(directory, file)
            if os.path.isfile(file_directory):
                fields = ['date', 'cyan', 'magenta', 'yellow',
                          'black', 'print_mode', 'image_length', 'image_width', 'image_result', 'printer_id']
                image = pd.read_csv(file_directory, sep=';', usecols=fields)
                try:
                    mydb = connection.connect(host=DBconnection.get_host_string(), database=DBconnection.get_db_string(),
                                      user=DBconnection.get_user_string(), passwd=DBconnection.get_password_string(),
                                      use_pure=True)
                    cursor = mydb.cursor()
                    print("You're connected to database")
                    query = "SELECT date, cyan, magenta, yellow, black, print_mode, image_length, image_width, image_result, printer_id FROM `image` "
                    databaseContents = pd.read_sql(query, mydb)
                    databaseContents.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "databaseContentsImage.csv"))
                    updatedDatabaseData = pd.concat([image, databaseContents])
                    updatedDatabaseData = updatedDatabaseData.drop_duplicates(subset=['date', 'cyan', 'magenta', 'yellow', 'black', 'print_mode', 'image_length', 'image_width', 'image_result', 'printer_id' ])
                    updatedDatabaseData.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataImage.csv"))
                    sql_delete_old_image_data="DELETE FROM `image`"
                    sql_alter_image_autoIncrement="ALTER TABLE `image` AUTO_INCREMENT = 1"
                    cursor.execute(sql_delete_old_image_data)
                    cursor.execute(sql_alter_image_autoIncrement)
                    image_data = pd.read_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataImage.csv"), usecols = ['date', 'cyan', 'magenta', 'yellow','black',  'print_mode', 'image_length', 'image_width', 'image_result', 'printer_id' ])
                    for i,row in image_data.iterrows():
                        #here %S means string values 
                        sql_image = "INSERT INTO `image` (date, image_result, image_length, image_width, print_mode, cyan, magenta, yellow, black,printer_id) VALUES (%s,%s,%s,%s,%s,%s,%s,%s,%s,%s)"
                        cursor.execute(sql_image, tuple(row))
                        mydb.commit()

                except Error as e:
                    print("Error while connecting to the database", e)
    
        mydb.close()


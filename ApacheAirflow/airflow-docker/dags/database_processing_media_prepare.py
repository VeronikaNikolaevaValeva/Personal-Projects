# -*- coding: utf-8 -*-
import os

import pandas as pd
import re
from mysql.connector import Error
import mysql.connector as connection
from DBconnection import DBconnection
from tasks_methods import check_unprocessed_files_count

def database_processing_media_prepare():
    if not check_unprocessed_files_count(
            os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_media_prepare.csv")):
        directory = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/media_prepare"))
        for file in os.listdir(directory):
            file_directory = os.path.join(directory, file)
            if os.path.isfile(file_directory):
                fields = ['date', 'media_category', 'printer_id']
                media_prepare = pd.read_csv(file_directory, sep=';', usecols=fields)
                try:
                    mydb = connection.connect(host=DBconnection.get_host_string(), database=DBconnection.get_db_string(),
                                      user=DBconnection.get_user_string(), passwd=DBconnection.get_password_string(),
                                      use_pure=True)
                    cursor = mydb.cursor()
                    print("You're connected to database")
                    query = "SELECT date, media_category, printer_id FROM `media_prepare` "
                    database_contents = pd.read_sql(query, mydb)
                    database_contents.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "databaseContentsMediaPrepare.csv"))
                    updatedDatabaseData = pd.concat([media_prepare, database_contents])
                    updatedDatabaseData = updatedDatabaseData.drop_duplicates(subset=['date', 'media_category', 'printer_id'])
                    updatedDatabaseData.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataMediaPrepare.csv"))
                    sql_delete_old_media_prepare_data="DELETE FROM `media_prepare`"
                    sql_alter_media_prepare_autoIncrement="ALTER TABLE `media_prepare` AUTO_INCREMENT = 1"
                    cursor.execute(sql_delete_old_media_prepare_data)
                    cursor.execute(sql_alter_media_prepare_autoIncrement)
                    media_prepare_data = pd.read_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataMediaPrepare.csv"), usecols = ['date', 'media_category', 'printer_id'])
                    for k,row in media_prepare_data.iterrows():
                        #here %S means string values 
                        sql_media_prepare = "INSERT INTO `media_prepare` (date, media_category, printer_id) VALUES (%s,%s,%s)"
                        cursor.execute(sql_media_prepare, tuple(row))
                        mydb.commit()
        
                except Error as e:
                    print("Error while connecting to the database", e)
        
        mydb.close()


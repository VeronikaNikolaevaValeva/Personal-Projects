# -*- coding: utf-8 -*-
import os

import pandas as pd
import re
from mysql.connector import Error
import mysql.connector as connection
from DBconnection import DBconnection

from tasks_methods import check_unprocessed_files_count

def database_processing_print_cycle():
    if not check_unprocessed_files_count(
            os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_print_cycle.csv")):
        directory = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/print_cycle"))
        for file in os.listdir(directory):
            file_directory = os.path.join(directory, file)
            if os.path.isfile(file_directory):
                fields = ['date', 'print_volume', 'printer_id']
                print_cycle = pd.read_csv(file_directory, sep=';', usecols=fields)
                
                try:
                    mydb = connection.connect(host=DBconnection.get_host_string(), database=DBconnection.get_db_string(),
                                      user=DBconnection.get_user_string(), passwd=DBconnection.get_password_string(),
                                      use_pure=True)
                    cursor = mydb.cursor()
                    print("You're connected to database")
                    query = "SELECT date, print_volume,printer_id FROM `print_cycle` "
                    databaseContents = pd.read_sql(query, mydb)
                    databaseContents.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "databaseContentsPrintCycle.csv"))
                    updatedDatabaseData = pd.concat([print_cycle, databaseContents])
                    updatedDatabaseData = updatedDatabaseData.drop_duplicates(subset=['date', 'print_volume', 'printer_id'])
                    updatedDatabaseData.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataPrintCycle.csv"))
                    sql_alter_print_cycle_autoIncrement="ALTER TABLE `print_cycle` AUTO_INCREMENT = 1"
                    sql_delete_old_print_cycle_data="DELETE FROM `print_cycle`"
                    cursor.execute(sql_delete_old_print_cycle_data)
                    cursor.execute(sql_alter_print_cycle_autoIncrement)
                    print_cycle_data = pd.read_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataPrintCycle.csv"), usecols = ['date', 'print_volume', 'printer_id'])
        
                    for j,row in print_cycle_data.iterrows():
                        #here %S means string values 
                        sql_print_cycle = "INSERT INTO `print_cycle` ( date, print_volume, printer_id) VALUES (%s,%s, %s)"
                        cursor.execute(sql_print_cycle, tuple(row))
                        mydb.commit()
                except Error as e:
                    print("Error while connecting to the database", e)
    
    
        mydb.close()


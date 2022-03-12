# -*- coding: utf-8 -*-
from airflow import DAG
from datetime import datetime, timedelta
from airflow.operators.bash import BashOperator
from airflow.operators.python import PythonOperator, BranchPythonOperator
import os
from check_file_changes import file_changes
from pre_processing_image import pre_process_image
from col_processing_image import col_process_image
from pre_processing_media_prepare import pre_process_media_prepare
from col_processing_media_prepare import col_process_media_prepare
from pre_processing_print_cycle import pre_process_print_cycle
from col_processing_print_cycle import col_process_print_cycle
from refactor_processing_image import refactor_process_image
from refactor_processing_media_prepare import refactor_process_media_prepare
from refactor_processing_print_cycle import refactor_process_print_cycle
from database_processing_image import database_processing_image
from database_processing_media_prepare import database_processing_media_prepare
from database_processing_print_cycle import database_processing_print_cycle
from delete_working_files import delete_working_files
from update_processed_files_image import update_processed_files_image
from update_processed_files_print_cycle import update_processed_files_print_cycle
from update_processed_files_media_prepare import update_processed_files_media_prepare


OFFICIAL_DATA_FILES_DIRECTORY = os.environ['OFFICIAL_DATA_FILES_DIRECTORY']


default_args = {"owner": "airflow", "start_date": datetime(2021, 6, 12)}
with DAG(dag_id="cpp_workflow", default_args=default_args, schedule_interval='@daily') as dag:

    check_file_changes = PythonOperator(
        task_id="check_file_changes",
        python_callable=file_changes
    )
    pre_process_image = PythonOperator(
        task_id="pre_process_image",
        python_callable=pre_process_image
    )
    col_process_image = PythonOperator(
        task_id="col_process_image",
        python_callable=col_process_image
    )
    pre_process_media_prepare = PythonOperator(
        task_id="pre_process_media_prepare",
        python_callable=pre_process_media_prepare
    )
    col_process_media_prepare = PythonOperator(
        task_id="col_process_media_prepare",
        python_callable=col_process_media_prepare
    )
    pre_process_print_cycle = PythonOperator(
        task_id="pre_process_print_cycle",
        python_callable=pre_process_print_cycle
    )
    col_process_print_cycle = PythonOperator(
        task_id="col_process_print_cycle",
        python_callable=col_process_print_cycle
    )
    refactor_process_image = PythonOperator(
        task_id="refactor_process_image",
        python_callable=refactor_process_image
    )
    refactor_process_media_prepare = PythonOperator(
        task_id="refactor_process_media_prepare",
        python_callable=refactor_process_media_prepare
    )
    refactor_process_print_cycle = PythonOperator(
        task_id="refactor_process_print_cycle",
        python_callable=refactor_process_print_cycle
    )
    database_processing_image = PythonOperator(
        task_id = "database_processing_image",
        python_callable=database_processing_image
    )
    database_processing_media_prepare = PythonOperator(
        task_id = "database_processing_media_prepare",
        python_callable=database_processing_media_prepare
    )
    database_processing_print_cycle = PythonOperator(
        task_id = "database_processing_print_cycle",
        python_callable=database_processing_print_cycle
    )
    update_processed_files_image = PythonOperator(
        task_id='update_processed_files_image',
        python_callable=update_processed_files_image
    )
    update_processed_files_media_prepare = PythonOperator(
        task_id='update_processed_files_media_prepare',
        python_callable=update_processed_files_media_prepare
    )
    update_processed_files_print_cycle = PythonOperator(
        task_id='update_processed_files_print_cycle',
        python_callable=update_processed_files_print_cycle
    )
    delete_working_files = PythonOperator(
        task_id='delete_working_files',
        python_callable=delete_working_files,
        trigger_rule='all_done'
    )

    check_file_changes >> pre_process_image >> col_process_image >> refactor_process_image >> database_processing_image >> update_processed_files_image >> delete_working_files
    check_file_changes >> pre_process_media_prepare >> col_process_media_prepare >> refactor_process_media_prepare >> database_processing_media_prepare >> update_processed_files_media_prepare >> delete_working_files
    check_file_changes >> pre_process_print_cycle >> col_process_print_cycle >> refactor_process_print_cycle >> database_processing_print_cycle >> update_processed_files_print_cycle >> delete_working_files
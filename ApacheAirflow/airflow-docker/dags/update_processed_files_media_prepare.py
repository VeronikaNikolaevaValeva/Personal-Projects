import os

import pandas as pd


def update_processed_files_media_prepare():
    file_directory = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_media_prepare.csv")
    last_dag_execution_directory = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'],
                                                "last_dag_execution_files_media_prepare.csv")
    media = pd.read_csv(file_directory)
    media.to_csv(last_dag_execution_directory, index=False)
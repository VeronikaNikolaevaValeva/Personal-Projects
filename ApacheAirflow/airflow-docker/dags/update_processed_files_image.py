import os

import pandas as pd


def update_processed_files_image():
    file_directory = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_image.csv")
    last_dag_execution_directory = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "last_dag_execution_files_image.csv")
    image = pd.read_csv(file_directory)
    image.to_csv(last_dag_execution_directory, index=False)

import os

import pandas as pd


def update_processed_files_print_cycle():
    file_directory = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_print_cycle.csv")
    last_dag_execution_directory = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'],
                                                "last_dag_execution_files_print_cycle.csv")
    print_cycle = pd.read_csv(file_directory)
    print_cycle.to_csv(last_dag_execution_directory, index=False)
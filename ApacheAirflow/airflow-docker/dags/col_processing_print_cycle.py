# -*- coding: utf-8 -*-
import csv
import os

import numpy as np
import pandas as pd
import re

from tasks_methods import check_unprocessed_files_count


def col_process_print_cycle():
    if not check_unprocessed_files_count(
            os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_print_cycle.csv")):
        directory = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/print_cycle"))
        for file in os.listdir(directory):
            file_directory = os.path.join(directory, file)
            if os.path.isfile(file_directory):
                fields = ['printer_id', 'date', 'time', 'SquareDecimeter[dm2]']
                print_cycle_data = pd.read_csv(file_directory, sep=';', usecols=fields)
                print_cycle_data.to_csv(file_directory, index=False, sep=';')

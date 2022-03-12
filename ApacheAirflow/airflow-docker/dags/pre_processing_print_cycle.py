# -*- coding: utf-8 -*-
import os

import pandas as pd
import re

from tasks_methods import pre_process, check_unprocessed_files_count


def pre_process_print_cycle():
    if not check_unprocessed_files_count(
            os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_print_cycle.csv")):

        with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_print_cycle.csv")) as f:
            saving_folder = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/print_cycle"))
            pre_process(f, saving_folder)

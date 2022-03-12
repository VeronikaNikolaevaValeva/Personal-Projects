# -*- coding: utf-8 -*-
import os

import pandas as pd
import re

from tasks_methods import pre_process
from tasks_methods import check_unprocessed_files_count


def pre_process_image():
    if not check_unprocessed_files_count(
            os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_image.csv")):
        with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_image.csv")) as f:
            saving_folder = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/image"))
            pre_process(f, saving_folder)

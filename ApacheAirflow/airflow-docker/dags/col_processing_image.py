# -*- coding: utf-8 -*-
import os

import pandas as pd
import re

from tasks_methods import check_unprocessed_files_count


def col_process_image():
    if not check_unprocessed_files_count(
            os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_image.csv")):
        directory = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/image"))
        for file in os.listdir(directory):
            file_directory = os.path.join(directory, file)
            if os.path.isfile(file_directory):
                fields = ['printer_id', 'date', 'time', 'JettedInkCyan[ml]', 'JettedInkMagenta[ml]', 'JettedInkYellow[ml]',
                          'JettedInkBlack[ml]',
                          'PrintMode', 'ImageLength[m]', 'ImageWidth[m]', 'ImageResult']
                image = pd.read_csv(file_directory, sep=';', usecols=fields)
                image.to_csv(file_directory, index=False, sep=';')

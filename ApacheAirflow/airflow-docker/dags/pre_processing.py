# -*- coding: utf-8 -*-
import os

import pandas as pd
import re


def pre_process():
    image_data = pd.read_csv(os.path.join(os.environ['OFFICIAL_DATA_FILES_DIRECTORY'], "Image.csv"), sep=';')
    mediaprepare_data = pd.read_csv(os.path.join(os.environ['OFFICIAL_DATA_FILES_DIRECTORY'], "MediaPrepare.csv"), sep=';')
    printcycle_data = pd.read_csv(os.path.join(os.environ['OFFICIAL_DATA_FILES_DIRECTORY'], "PrintCycle.csv"), sep=';')

    if image_data.isnull().values.any():
        image_data = image_data.dropna(axis=0, how='any')

    if mediaprepare_data.isnull().values.any():
        mediaprepare_data = mediaprepare_data.dropna(axis=0, how='any')

    if printcycle_data.isnull().values.any():
        printcycle_data = printcycle_data.dropna(axis=0, how='any')

    image_data.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "IMAGE_Data.csv"))
    mediaprepare_data.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "MEDIA_PREPARE_Data.csv"))
    printcycle_data.to_csv(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "PRINT_CYCLE_Data.csv"))

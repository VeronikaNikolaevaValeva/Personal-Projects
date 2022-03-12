import os

import pandas as pd


def pre_process(f, saving_folder):
    for row in f:
        row_of_first_column = row.split(',')[0]
        file_hash = row.split(',')[1]
        printer_id = row.split(',')[2]
        file = pd.read_csv(row_of_first_column, sep=';')
        if file.isnull().values.any():
            file.dropna(axis=0, how='any')
        file.columns = file.columns.str.replace('$','')
        file.columns = file.columns.str.replace('~', '')
        file.columns = file.columns.str.replace('#', '')
        file.columns = file.columns.str.replace('>', '')
        file['printer_id'] = printer_id
        file.to_csv(os.path.join(saving_folder, file_hash), index=False, sep=';')


def check_unprocessed_files_count(f):
    return os.stat(f).st_size == 0

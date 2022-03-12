import os
import hashlib
import csv


def file_changes():
    for directoryName in os.listdir(os.environ['OFFICIAL_DATA_FILES_DIRECTORY']):
        directory = os.path.join(os.environ['OFFICIAL_DATA_FILES_DIRECTORY'], directoryName, 'engineControl')
        printer_id = directoryName
        if os.path.isdir(directory):
            for directoryInEngineControl in os.listdir(directory):
                directory1 = os.path.join(directory, directoryInEngineControl)
                if os.path.isdir(directory1):
                    if directoryInEngineControl == "accounting":
                        directory1 = os.path.join(directory1, 'image')
                        for file in os.listdir(directory1):
                            file_directory = os.path.join(directory1, file)
                            if os.path.isfile(file_directory):
                                # this has to be changed
                                with open(file_directory, "rb") as f:
                                    bytes_in_file = f.read()
                                    readable_hash = hashlib.sha256(bytes_in_file).hexdigest();
                                    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_image.csv"),
                                              'a', newline='') as hashed_files:
                                        writer = csv.writer(hashed_files)
                                        writer.writerow([file_directory, readable_hash,printer_id])
                    if directoryInEngineControl == "MediaPrepare":
                        for file in os.listdir(directory1):
                            file_directory = os.path.join(directory1, file)
                            if os.path.isfile(file_directory):
                                # this has to be changed
                                with open(file_directory, "rb") as f:
                                    bytes_in_file = f.read()
                                    readable_hash = hashlib.sha256(bytes_in_file).hexdigest();
                                    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_media_prepare.csv"), 'a', newline='') as hashed_files:
                                        writer = csv.writer(hashed_files)
                                        writer.writerow([file_directory, readable_hash, printer_id])
                    if directoryInEngineControl == "PrintCycle":
                        for file in os.listdir(directory1):
                            file_directory = os.path.join(directory1, file)
                            # this has to be changed
                            if os.path.isfile(file_directory):
                                with open(file_directory, "rb") as f:
                                    bytes_in_file = f.read()
                                    readable_hash = hashlib.sha256(bytes_in_file).hexdigest();
                                    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_print_cycle.csv"), 'a', newline='') as hashed_files:
                                        writer = csv.writer(hashed_files)
                                        writer.writerow([file_directory, readable_hash, printer_id])

    # this has to be changed
    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_image.csv"), 'r') as t1, open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "last_dag_execution_files_image.csv"), 'r') as t2:
        fileone = t1.readlines()
        filetwo = t2.readlines()

    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_image.csv"), 'w') as outFile:
        for line in fileone:
            if line not in filetwo:
                outFile.write(line)

    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_media_prepare.csv"), 'r') as t1, open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "last_dag_execution_files_media_prepare.csv"), 'r') as t2:
        fileone = t1.readlines()
        filetwo = t2.readlines()

    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_media_prepare.csv"), 'w') as outFile:
        for line in fileone:
            if line not in filetwo:
                outFile.write(line)

    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_print_cycle.csv"), 'r') as t1, open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "last_dag_execution_files_print_cycle.csv"), 'r') as t2:
        fileone = t1.readlines()
        filetwo = t2.readlines()

    with open(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_print_cycle.csv"), 'w') as outFile:
        for line in fileone:
            if line not in filetwo:
                outFile.write(line)
        


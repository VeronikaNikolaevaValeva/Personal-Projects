import os


def delete_working_files():
    os.remove(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_image.csv"))
    os.remove(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_media_prepare.csv"))
    os.remove(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "not_processed_files_print_cycle.csv"))
    os.remove(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_image.csv"))
    os.remove(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_media_prepare.csv"))
    os.remove(os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "hashed_files_print_cycle.csv"))

    databaseContentsImage = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "databaseContentsImage.csv")
    if os.path.isfile(databaseContentsImage):
        os.remove(databaseContentsImage)
    databaseContentsMediaPrepare = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "databaseContentsMediaPrepare.csv")
    if os.path.isfile(databaseContentsMediaPrepare):
        os.remove(databaseContentsMediaPrepare)
    databaseContentsPrintCycle = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "databaseContentsPrintCycle.csv")
    if os.path.isfile(databaseContentsPrintCycle):
        os.remove(databaseContentsPrintCycle)

    updatedDatabaseDataImage = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataImage.csv")
    if os.path.isfile(updatedDatabaseDataImage):
        os.remove(updatedDatabaseDataImage)
    updatedDatabaseDataPrintCycle = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataPrintCycle.csv")
    if os.path.isfile(updatedDatabaseDataPrintCycle):
        os.remove(updatedDatabaseDataPrintCycle)
    updatedDatabaseDataMediaPrepare = os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "updatedDatabaseDataMediaPrepare.csv")
    if os.path.isfile(updatedDatabaseDataMediaPrepare):
        os.remove(updatedDatabaseDataMediaPrepare)

    directory = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/image"))
    for file in os.listdir(directory):
        os.remove(os.path.join(directory, file))
    directory = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/print_cycle"))
    for file in os.listdir(directory):
        os.remove(os.path.join(directory, file))
    directory = (os.path.join(os.environ['TEST_DATA_FILES_DIRECTORY'], "processing_files/media_prepare"))
    for file in os.listdir(directory):
        os.remove(os.path.join(directory, file))



OPTIONS (SKIP=1)  -- Skip the header row in the CSV file

LOAD DATA
CHARACTERSET UTF8
INFILE 'data/sinhvien.csv'  -- Name of your CSV data file
APPEND INTO TABLE SINHVIEN
FIELDS TERMINATED BY ','  -- Fields are comma-separated
OPTIONALLY ENCLOSED BY '"'  -- Fields are optionally enclosed by double quotes
TRAILING NULLCOLS
(
    MASV CHAR,
    HOTEN CHAR,
    PHAI CHAR,
    NGSINH DATE 'YYYY-MM-DD',
    DCHI CHAR,
    DT CHAR,
    MACT CHAR,
    MANGANH CHAR,
    SOTCTL INTEGER EXTERNAL,
    DTBTL FLOAT EXTERNAL
)

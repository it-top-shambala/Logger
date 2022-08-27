CREATE TABLE tab_log_info
(
    id       INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    log_date TEXT NOT NULL,
    log_time TEXT NOT NULL,
    message TEXT NOT NULL
);
CREATE TABLE tab_log_warning
(
    id       INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    log_date TEXT NOT NULL,
    log_time TEXT NOT NULL,
    message TEXT NOT NULL
);
CREATE TABLE tab_log_error
(
    id       INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    log_date TEXT NOT NULL,
    log_time TEXT NOT NULL,
    message TEXT NOT NULL
);
CREATE TABLE tab_log_success
(
    id       INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    log_date TEXT NOT NULL,
    log_time TEXT NOT NULL,
    message TEXT NOT NULL
);
CREATE TABLE tab_log_custom
(
    id       INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    log_date TEXT NOT NULL,
    log_time TEXT NOT NULL,
    message TEXT NOT NULL
);
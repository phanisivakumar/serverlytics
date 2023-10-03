USE Serverlytics;
GO

CREATE TABLE ServerHealth (
	serialNum INT IDENTITY(1,1) PRIMARY KEY,
    databaseName NVARCHAR(255),
    primaryServer NVARCHAR(255),
    secondaryServer NVARCHAR(255),
    syncState NVARCHAR(50),
    syncHealth NVARCHAR(50),
    availMode NVARCHAR(50),
    failMode NVARCHAR(50),
    syncDelay INT,
    listnerName NVARCHAR(255),
    dataCollected DATETIME,
    region NVARCHAR(50),
    appName NVARCHAR(255),
    alwaysOnRole NVARCHAR(50)
	--,  CONSTRAINT PK_ServerHealth PRIMARY KEY (databaseName, primaryServer, secondaryServer)
);

GO

INSERT INTO ServerHealth (
    databaseName,
    primaryServer,
    secondaryServer,
    syncState,
    syncHealth,
    availMode,
    failMode,
    syncDelay,
    listnerName,
    dataCollected,
    region,
    appName,
    alwaysOnRole
)
VALUES
    ('Organizer_2013', 'DERUSVMDBSQ05\bINST1', 'USSECBMDOGSSQ06\bDEV2_OGS', 'SYNCHRONIZED', 'HEALTHY', 'SYNCHRONOUS_COMMIT', 'AUTOMATIC', 0, 'USSECOGSGRPSQL9.eydev.net', '2023-07-31 17:26:10', 'EMEIA', 'EYGlobalOne(OGS)', 'PRIMARY'),
    ('Organizer_2013', 'USSECBMDOGSSQ04\bDEV1_OGS', 'USSECBMDOGSSQ06\bDEV2_OGS', 'SYNCHRONIZED', 'HEALTHY', 'SYNCHRONOUS_COMMIT', 'AUTOMATIC', 0, 'USSECOGSGRPSQL9.eydev.net', '2023-07-31 17:26:10', 'EMEIA', 'EYGlobalOne(OGS)', 'PRIMARY'),
    ('OGPArchive', 'USSECBMDOGSSQ05\bDEV2_OGS', 'USSECBMDOGSSQ04\bDEV1_OGS', 'SYNCHRONIZED', 'HEALTHY', 'SYNCHRONOUS_COMMIT', 'AUTOMATIC', 0, 'USSECOGSGRPSQ21.eydev.net', '2023-07-31 17:14:30', 'Americas', 'TaxCostEstimator(TCE)', 'SECONDARY'),
    ('Organizer_2013', 'USSECBMDOGSSQ06\bDEV2_OGS', 'USSECBMDOGSSQ06\bDEV2_OGS', 'SYNCHRONIZED', 'HEALTHY', 'SYNCHRONOUS_COMMIT', 'AUTOMATIC', 0, 'USSECOGSGRPSQL9.eydev.net', '2023-07-31 17:26:10', 'EMEIA', 'EYGlobalOne(OGS)', 'PRIMARY'),
    ('OGPArchive', 'DERUSVMDBSQ04\bINST1', 'USSECBMDOGSSQ04\bDEV1_OGS', 'SYNCHRONIZED', 'HEALTHY', 'SYNCHRONOUS_COMMIT', 'AUTOMATIC', 0, 'USSECOGSGRPSQ21.eydev.net', '2023-07-31 17:14:30', 'Americas', 'TaxCostEstimator(TCE)', 'SECONDARY'),
    ('OGPArchive', 'DERUSVMDBSQ05\bINST1', 'USSECBMDOGSSQ06\bDEV2_OGS', 'SYNCHRONIZED', 'HEALTHY', 'SYNCHRONOUS_COMMIT', 'AUTOMATIC', 0, 'USSECOGSGRPSQL9.eydev.net', '2023-07-31 17:26:10', 'EMEIA', 'EYGlobalOne(OGS)', 'PRIMARY'),
    ('OGPArchive', 'DERUSVMDBSQ06\bINST1', 'USSECBMDOGSSQ04\bDEV1_OGS', 'SYNCHRONIZED', 'HEALTHY', 'SYNCHRONOUS_COMMIT', 'AUTOMATIC', 0, 'USSECOGSGRPSQ21.eydev.net', '2023-07-31 17:14:30', 'Americas', 'TaxCostEstimator(TCE)', 'SECONDARY'),
    ('OGPArchive', 'DERUSVMDGCRSQ02\bINST1', 'USSECBMDOGSSQ06\bDEV2_OGS', 'SYNCHRONIZED', 'HEALTHY', 'SYNCHRONOUS_COMMIT', 'AUTOMATIC', 0, 'USSECOGSGRPSQL9.eydev.net', '2023-07-31 17:26:10', 'EMEIA', 'EYGlobalOne(OGS)', 'PRIMARY');
GO
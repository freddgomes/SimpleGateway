USE SimpleGatewayDb
GO
CREATE TABLE [dbo].[Transactions](
	Id [uniqueidentifier] NOT NULL,
    MerchantId [uniqueidentifier] NOT NULL,
     MerchantOrderId varchar(50) NOT NULL,
     CustomerName varchar(255) NULL,
     ServiceTaxAmount  int NULL,
     Installments int NOT NULL DEFAULT ((1)),
     Capture bit NOT NULL DEFAULT ((0)),
     Authenticate bit NOT NULL DEFAULT ((0)),
     Recurrent bit NOT NULL DEFAULT ((0)),
     Tid varchar(100) NOT NULL,
     ProofOfSale varchar(100) NULL,
     AuthorizationCode varchar(100) NULL,
     Provider varchar(50) NULL, 
     Amount bigint NOT NULL, 
     ReceivedDate varchar(30) NOT NULL,
     CapturedAmount bigint NULL,
     CapturedDate varchar(30) NULL,
     [Status] int NOT NULL  DEFAULT ((0)),
     IsSplitted bit NOT NULL DEFAULT ((0)), 
     ReturnMessage varchar(255) NULL,
     ReturnCode varchar(100) NULL,
     PaymentId varchar(100) NOT NULL,
     [Type] varchar(100) NOT NULL, 
     Currency varchar(3) NULL,
     Country varchar(3) NULL,
     CardNumber varchar(20) NOT NULL, 
     Brand varchar(10) NOT NULL
CONSTRAINT PK_Transactions PRIMARY KEY (Id)
);
GO
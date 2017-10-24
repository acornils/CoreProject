USE [master]
GO
/****** Object:  Database [Core]    Script Date: 10/23/2017 9:27:19 PM ******/
CREATE DATABASE [Core]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoreDB', FILENAME = N'C:\GitRepo\CoreProject\DB\CoreDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CoreDB_log', FILENAME = N'C:\GitRepo\CoreProject\DB\CoreDB_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Core] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Core].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Core] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Core] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Core] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Core] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Core] SET ARITHABORT OFF 
GO
ALTER DATABASE [Core] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Core] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Core] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Core] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Core] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Core] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Core] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Core] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Core] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Core] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Core] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Core] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Core] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Core] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Core] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Core] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Core] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Core] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Core] SET  MULTI_USER 
GO
ALTER DATABASE [Core] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Core] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Core] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Core] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Core] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Core] SET QUERY_STORE = OFF
GO
USE [Core]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Core]
GO
/****** Object:  User [user1]    Script Date: 10/23/2017 9:27:19 PM ******/
CREATE USER [user1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [user1]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [user1]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [user1]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [user1]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [user1]
GO
ALTER ROLE [db_datareader] ADD MEMBER [user1]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [user1]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [user1]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [user1]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 10/23/2017 9:27:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[shortName] [nvarchar](max) NULL,
	[ScannerMAC] [nvarchar](max) NULL,
	[ScannerHead] [nvarchar](50) NULL,
	[isRFIDRead] [bit] NULL,
	[isDeleted] [bit] NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_1]    Script Date: 10/23/2017 9:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT        dbo.Paths.ID, dbo.Paths.RouteID, dbo.Paths.locationID, dbo.Paths.nextLocationID, dbo.Paths.symbol, dbo.Paths.defaultStatus, dbo.Paths.isStart, dbo.Paths.isEnd, 
                         dbo.Locations.name
FROM            dbo.Locations INNER JOIN
                         dbo.Paths ON dbo.Locations.ID = dbo.Paths.locationID
GO
/****** Object:  Table [dbo].[rollingStockAtrributes]    Script Date: 10/23/2017 9:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rollingStockAtrributes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[rollingStockID] [int] NULL,
	[carTypeAttrID] [int] NULL,
 CONSTRAINT [PK_rollingStockAtrributes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RollingStock]    Script Date: 10/23/2017 9:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RollingStock](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[roadNumber] [nvarchar](max) NULL,
	[arrCodeID] [int] NULL,
	[displayText] [nvarchar](max) NULL,
	[length] [int] NULL,
	[capacityTonnage] [int] NULL,
	[carTypeID] [int] NULL,
	[locationID] [int] NULL,
	[RFID] [nvarchar](max) NULL,
	[trainID] [int] NULL,
	[isNotConfiscatable] [bit] NULL,
	[nextRS] [int] NULL,
	[isFirst] [bit] NULL,
	[isLast] [bit] NULL,
	[isOutOfService] [bit] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_2]    Script Date: 10/23/2017 9:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_2]
AS
SELECT        dbo.RollingStock.ID AS Expr1, dbo.rollingStockAtrributes.carTypeAttrID, dbo.RollingStock.*, dbo.WaybillTemplateRequestedCarTypeAttribute.waybillID
FROM            dbo.RollingStock INNER JOIN
                         dbo.rollingStockAtrributes ON dbo.RollingStock.ID = dbo.rollingStockAtrributes.rollingStockID INNER JOIN
                         dbo.WaybillTemplateRequestedCarTypeAttribute ON dbo.rollingStockAtrributes.carTypeAttrID = dbo.WaybillTemplateRequestedCarTypeAttribute.carTypeAttributeID
GO
/****** Object:  Table [dbo].[ARRCodes]    Script Date: 10/23/2017 9:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARRCodes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[No] [nvarchar](10) NULL,
	[Carrier] [nvarchar](50) NULL,
	[Abbr] [nvarchar](10) NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_ARRCodes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillOfLading]    Script Date: 10/23/2017 9:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillOfLading](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[consigneeID] [int] NULL,
	[shipperID] [int] NULL,
	[carTypeRequestedID] [int] NULL,
	[carLengthRequested] [int] NULL,
	[carCapacityRequested] [int] NULL,
	[noPackages] [nvarchar](max) NULL,
	[descriptionOfArticles] [nvarchar](max) NULL,
	[displayText] [nvarchar](max) NULL,
	[isPerishable] [bit] NULL,
	[isPreIce] [bit] NULL,
	[isInitialIce] [bit] NULL,
	[cps] [int] NULL,
	[isEmptyCarRequested] [bit] NULL,
	[isLiveStock] [bit] NULL,
	[isReverseRoute] [bit] NULL,
	[isReturnEmpty] [bit] NULL,
	[requestedCarsPerDay] [decimal](18, 0) NULL,
	[timeToUnload] [int] NULL,
	[timeToLoad] [int] NULL,
	[isDeleted] [bit] NULL,
	[createdOn] [datetime] NULL,
	[modifiedOn] [datetime] NULL,
 CONSTRAINT [PK_WaybillTemplates] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillOfLadingPath]    Script Date: 10/23/2017 9:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillOfLadingPath](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[billOfLadingID] [int] NULL,
	[locationID] [int] NULL,
	[nextID] [int] NULL,
	[isFirst] [bit] NULL,
 CONSTRAINT [PK_WaybillTemplatePath] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillOfLadingRequestedCarTypeAttribute]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillOfLadingRequestedCarTypeAttribute](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[billOfLadingID] [int] NULL,
	[carTypeAttributeID] [int] NULL,
 CONSTRAINT [PK_WaybillRequestedCarTypeAttribute] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarType]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[shortName] [nvarchar](max) NULL,
	[longName] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_CarType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarTypeAttributes]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarTypeAttributes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[carTypeID] [int] NULL,
	[attribute] [nvarchar](max) NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_CarTypeAttributes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConsigneeShipper]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConsigneeShipper](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[locationID] [int] NULL,
	[name] [nvarchar](max) NULL,
	[aarCodeID] [int] NULL,
 CONSTRAINT [PK_ShipperConsignees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmptyCarBill]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmptyCarBill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[isForHome] [bit] NULL,
	[billedFromID] [int] NULL,
	[billedToVia] [int] NULL,
	[RollingStockID] [int] NULL,
	[billOfLadingID] [int] NULL,
	[canConfiscate] [bit] NULL,
	[onSpotAtShipper] [int] NULL,
	[onSpotAtConsignee] [int] NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_EmptyCarBill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rfid]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rfid](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[postdata] [nvarchar](max) NULL,
	[scanner] [nvarchar](max) NULL,
	[head] [nvarchar](max) NULL,
	[tag] [nvarchar](max) NULL,
	[scannedAt] [datetime] NULL,
	[lastScanned] [bit] NULL,
 CONSTRAINT [PK_rfid] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[value] [nvarchar](max) NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SwitchListsLayouts]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SwitchListsLayouts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[image] [image] NULL,
	[firstRowStart] [int] NULL,
	[rowSpacing] [int] NULL,
	[initialColumn] [int] NULL,
	[numberColumn] [int] NULL,
	[kindColumn] [int] NULL,
	[contentsColumn] [int] NULL,
	[originColumn] [int] NULL,
	[destinationColumn] [int] NULL,
	[tonsColumn] [int] NULL,
	[remarksColumn] [int] NULL,
	[trainNoLocation] [nvarchar](max) NULL,
	[engineNoLocation] [nvarchar](max) NULL,
	[stationLocation] [nvarchar](max) NULL,
	[timeLocation] [nvarchar](max) NULL,
	[yearLocation] [nvarchar](max) NULL,
	[dateLocation] [nvarchar](max) NULL,
	[maxRows] [int] NULL,
	[backRowStart] [int] NULL,
	[maxRowsFront] [int] NULL,
 CONSTRAINT [PK_SwitchListsLayouts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Waybills]    Script Date: 10/23/2017 9:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Waybills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[billOfLadingID] [int] NULL,
	[consigneeID] [int] NULL,
	[shipperID] [int] NULL,
	[assignedRollingStockID] [int] NULL,
	[loadedAt] [datetime] NULL,
	[unloadedAt] [datetime] NULL,
	[preIcedAt] [datetime] NULL,
	[initialIcedAt] [datetime] NULL,
	[isWeighed] [bit] NULL,
	[weight] [int] NULL,
	[onSpotAtShipper] [int] NOT NULL,
	[onSpotAtConsignee] [int] NOT NULL,
	[isPerishableWaybill] [bit] NOT NULL,
	[isLiveStockWaybill] [bit] NOT NULL,
	[isEmptyWayBill] [bit] NOT NULL,
	[waybillOrder] [int] NULL,
	[isDeleted] [bit] NULL,
	[createdOn] [datetime] NULL,
	[modifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Waybills] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ARRCodes] ADD  CONSTRAINT [DF_ARRCodes_isDeleted]  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_carLengthRequested]  DEFAULT ((0)) FOR [carLengthRequested]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_isPerishable]  DEFAULT ((0)) FOR [isPerishable]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_isPreIce]  DEFAULT ((0)) FOR [isPreIce]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_isInitialIce]  DEFAULT ((0)) FOR [isInitialIce]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_cps]  DEFAULT ((1)) FOR [cps]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_isEmptyCarBill]  DEFAULT ((0)) FOR [isEmptyCarRequested]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_isLiveStock]  DEFAULT ((0)) FOR [isLiveStock]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_isReverseRoute]  DEFAULT ((0)) FOR [isReverseRoute]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_isReturnEmpty]  DEFAULT ((0)) FOR [isReturnEmpty]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_BillOfLading_requestedCarsPerDay]  DEFAULT ((0)) FOR [requestedCarsPerDay]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_timeToUnload]  DEFAULT ((0)) FOR [timeToUnload]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_timeToLoad]  DEFAULT ((0)) FOR [timeToLoad]
GO
ALTER TABLE [dbo].[BillOfLading] ADD  CONSTRAINT [DF_WaybillTemplates_isDelete]  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[BillOfLadingPath] ADD  CONSTRAINT [DF_WaybillTemplatePath_locationID]  DEFAULT ((0)) FOR [locationID]
GO
ALTER TABLE [dbo].[CarType] ADD  CONSTRAINT [DF_CarType_isDeleted]  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[CarTypeAttributes] ADD  CONSTRAINT [DF_CarTypeAttributes_isDeleted]  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[EmptyCarBill] ADD  CONSTRAINT [DF_EmptyCarBill_isForHome]  DEFAULT ((0)) FOR [isForHome]
GO
ALTER TABLE [dbo].[EmptyCarBill] ADD  CONSTRAINT [DF_EmptyCarBill_billedFromID]  DEFAULT ((0)) FOR [billedFromID]
GO
ALTER TABLE [dbo].[EmptyCarBill] ADD  CONSTRAINT [DF_EmptyCarBill_billedToVia]  DEFAULT ((0)) FOR [billedToVia]
GO
ALTER TABLE [dbo].[EmptyCarBill] ADD  CONSTRAINT [DF_EmptyCarBill_RollingStockID]  DEFAULT ((0)) FOR [RollingStockID]
GO
ALTER TABLE [dbo].[EmptyCarBill] ADD  CONSTRAINT [DF_EmptyCarBill_billOfLadingID]  DEFAULT ((0)) FOR [billOfLadingID]
GO
ALTER TABLE [dbo].[EmptyCarBill] ADD  CONSTRAINT [DF_EmptyCarBill_canConfiscate]  DEFAULT ((1)) FOR [canConfiscate]
GO
ALTER TABLE [dbo].[EmptyCarBill] ADD  CONSTRAINT [DF_EmptyCarBill_onSpotAtShipper]  DEFAULT ((0)) FOR [onSpotAtShipper]
GO
ALTER TABLE [dbo].[EmptyCarBill] ADD  CONSTRAINT [DF_EmptyCarBill_CreatedOn]  DEFAULT ((0)) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Locations] ADD  CONSTRAINT [DF_Locations_ScannerHead]  DEFAULT ((0)) FOR [ScannerHead]
GO
ALTER TABLE [dbo].[Locations] ADD  CONSTRAINT [DF_Locations_isRFIDRead]  DEFAULT ((0)) FOR [isRFIDRead]
GO
ALTER TABLE [dbo].[Locations] ADD  CONSTRAINT [DF_Locations_isDeleted]  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[rfid] ADD  CONSTRAINT [DF_rfid_lastScanned]  DEFAULT ((0)) FOR [lastScanned]
GO
ALTER TABLE [dbo].[RollingStock] ADD  CONSTRAINT [DF_RollingStock_capacityTonnage]  DEFAULT ((0)) FOR [capacityTonnage]
GO
ALTER TABLE [dbo].[RollingStock] ADD  CONSTRAINT [DF_RollingStock_locationID]  DEFAULT ((0)) FOR [locationID]
GO
ALTER TABLE [dbo].[RollingStock] ADD  CONSTRAINT [DF_RollingStock_isNotConfiscatable]  DEFAULT ((0)) FOR [isNotConfiscatable]
GO
ALTER TABLE [dbo].[RollingStock] ADD  CONSTRAINT [DF_RollingStock_isFirst]  DEFAULT ((0)) FOR [isFirst]
GO
ALTER TABLE [dbo].[RollingStock] ADD  CONSTRAINT [DF_RollingStock_isLast]  DEFAULT ((0)) FOR [isLast]
GO
ALTER TABLE [dbo].[RollingStock] ADD  CONSTRAINT [DF_RollingStock_isOutOfService]  DEFAULT ((0)) FOR [isOutOfService]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_assignedCarID]  DEFAULT ((0)) FOR [assignedRollingStockID]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_loadedAt]  DEFAULT (CONVERT([datetime],'1753-1-1')) FOR [loadedAt]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_unloadedAt]  DEFAULT (CONVERT([datetime],'1753-1-1')) FOR [unloadedAt]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_preIcedAt]  DEFAULT (CONVERT([datetime],'1753-1-1')) FOR [preIcedAt]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_initialIcedAt]  DEFAULT (CONVERT([datetime],'1753-1-1')) FOR [initialIcedAt]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_isWeighed]  DEFAULT ((0)) FOR [isWeighed]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_weight]  DEFAULT ((0)) FOR [weight]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_onSpotAtShipper]  DEFAULT ((0)) FOR [onSpotAtShipper]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_onSpotAtConsignee]  DEFAULT ((0)) FOR [onSpotAtConsignee]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_isPerishableWaybill]  DEFAULT ((0)) FOR [isPerishableWaybill]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_isLiveStockWaybill]  DEFAULT ((0)) FOR [isLiveStockWaybill]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_isEmptyWayBill]  DEFAULT ((0)) FOR [isEmptyWayBill]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_waybillOrder]  DEFAULT ((0)) FOR [waybillOrder]
GO
ALTER TABLE [dbo].[Waybills] ADD  CONSTRAINT [DF_Waybills_isDeleted]  DEFAULT ((0)) FOR [isDeleted]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Locations"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Paths"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "RollingStock"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 241
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "rollingStockAtrributes"
            Begin Extent = 
               Top = 36
               Left = 364
               Bottom = 199
               Right = 534
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "WaybillTemplateRequestedCarTypeAttribute"
            Begin Extent = 
               Top = 8
               Left = 727
               Bottom = 202
               Right = 916
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
USE [master]
GO
ALTER DATABASE [Core] SET  READ_WRITE 
GO

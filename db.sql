USE [master]
GO

/****** Object:  Database [ProyectoFinal]    Script Date: 18/07/2019 10:37:32 p.m. ******/
CREATE DATABASE [ProyectoFinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoFinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ProyectoFinal.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProyectoFinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ProyectoFinal_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoFinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ProyectoFinal] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ProyectoFinal] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ProyectoFinal] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ProyectoFinal] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ProyectoFinal] SET ARITHABORT OFF 
GO

ALTER DATABASE [ProyectoFinal] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ProyectoFinal] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ProyectoFinal] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ProyectoFinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ProyectoFinal] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ProyectoFinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ProyectoFinal] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ProyectoFinal] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ProyectoFinal] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ProyectoFinal] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ProyectoFinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ProyectoFinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ProyectoFinal] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ProyectoFinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ProyectoFinal] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ProyectoFinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ProyectoFinal] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ProyectoFinal] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ProyectoFinal] SET  MULTI_USER 
GO

ALTER DATABASE [ProyectoFinal] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ProyectoFinal] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ProyectoFinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ProyectoFinal] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [ProyectoFinal] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ProyectoFinal] SET  READ_WRITE 
GO

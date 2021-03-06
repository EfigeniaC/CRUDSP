USE [master]
GO
/****** Object:  Database [crudAlumnos]    Script Date: 29/05/2020 23:56:13 ******/
CREATE DATABASE [crudAlumnos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'crudAlumnos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.EFI_SERVER\MSSQL\DATA\crudAlumnos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'crudAlumnos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.EFI_SERVER\MSSQL\DATA\crudAlumnos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [crudAlumnos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [crudAlumnos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [crudAlumnos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [crudAlumnos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [crudAlumnos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [crudAlumnos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [crudAlumnos] SET ARITHABORT OFF 
GO
ALTER DATABASE [crudAlumnos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [crudAlumnos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [crudAlumnos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [crudAlumnos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [crudAlumnos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [crudAlumnos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [crudAlumnos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [crudAlumnos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [crudAlumnos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [crudAlumnos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [crudAlumnos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [crudAlumnos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [crudAlumnos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [crudAlumnos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [crudAlumnos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [crudAlumnos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [crudAlumnos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [crudAlumnos] SET RECOVERY FULL 
GO
ALTER DATABASE [crudAlumnos] SET  MULTI_USER 
GO
ALTER DATABASE [crudAlumnos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [crudAlumnos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [crudAlumnos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [crudAlumnos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [crudAlumnos] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'crudAlumnos', N'ON'
GO
ALTER DATABASE [crudAlumnos] SET QUERY_STORE = OFF
GO
USE [crudAlumnos]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 29/05/2020 23:56:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[idAlumnos] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[sexo] [char](1) NULL,
	[numero] [varchar](9) NOT NULL,
	[email] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idAlumnos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[idCurso] [int] IDENTITY(1,1) NOT NULL,
	[curso] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notas]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notas](
	[idNota] [int] IDENTITY(1,1) NOT NULL,
	[notaAlumno] [int] NULL,
	[notaCurso] [int] NULL,
	[nota1] [float] NOT NULL,
	[nota2] [float] NOT NULL,
	[nota3] [float] NOT NULL,
	[nota4] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Notas]  WITH CHECK ADD  CONSTRAINT [fk_notaAlumno] FOREIGN KEY([notaAlumno])
REFERENCES [dbo].[Alumnos] ([idAlumnos])
GO
ALTER TABLE [dbo].[Notas] CHECK CONSTRAINT [fk_notaAlumno]
GO
ALTER TABLE [dbo].[Notas]  WITH CHECK ADD  CONSTRAINT [fk_notaCurso] FOREIGN KEY([notaCurso])
REFERENCES [dbo].[Curso] ([idCurso])
GO
ALTER TABLE [dbo].[Notas] CHECK CONSTRAINT [fk_notaCurso]
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_ALUMNO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BUSCAR_ALUMNO]
@id_Alumno INTEGER
AS
BEGIN

SELECT nombre,apellidos,sexo,numero,email FROM Alumnos WHERE idAlumnos=@id_Alumno

END
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_CURSO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BUSCAR_CURSO]
@idCurso INTEGER
AS
BEGIN
SELECT* FROM Curso WHERE idCurso=@idCurso
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_Nota]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BUSCAR_Nota]
@idNota INTEGER
AS
BEGIN
SELECT* FROM Notas WHERE idNota=@idNota
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_CURSO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ELIMINAR_CURSO]
@idCurso INTEGER
AS
BEGIN
DELETE Curso WHERE idCurso=@idCurso
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_Nota]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ELIMINAR_Nota]
@idNota INTEGER
AS
BEGIN
DELETE Notas WHERE idNota=@idNota
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINIAR_ALUMNO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ELIMINIAR_ALUMNO]

@id_Alumno INTEGER

AS
BEGIN

DELETE FROM Alumnos WHERE idAlumnos=@id_Alumno
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTA_CURSO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTA_CURSO](
@curso VARCHAR(50)
)
AS
BEGIN
INSERT INTO Curso VALUES (@curso)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTA_NOTAS]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTA_NOTAS](
	@notaAlumno INTEGER,
	@notaCurso INTEGER,
	@nota1 FLOAT,
	@nota2 FLOAT,
	@nota3 FLOAT,
	@nota4 FLOAT
)
AS
BEGIN
INSERT INTO Notas VALUES (@notaAlumno,@notaCurso,@nota1,@nota2,@nota3,@nota4)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_ALUMNO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PROCEDIMIENTO INSERTAR
CREATE PROCEDURE [dbo].[SP_INSERTAR_ALUMNO]
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@sexo CHAR(1),
@numero VARCHAR(9),
@email VARCHAR(40)

AS
BEGIN

INSERT Alumnos (nombre,apellidos,sexo,numero,email) VALUES (@nombre,@apellido,@sexo,@numero,@email)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_ALUMNO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MODIFICAR_ALUMNO]

@idAlumnos INTEGER,
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@sexo CHAR(1),
@numero VARCHAR(9),
@email VARCHAR(40)
AS
BEGIN
UPDATE Alumnos SET	nombre=@nombre, apellidos=@apellido, sexo=@sexo, numero=@numero, email=@email
where idAlumnos = @idAlumnos
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_CURSO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MODIFICAR_CURSO]
@idCurso INTEGER,
@curso VARCHAR(50)
AS
BEGIN
UPDATE Curso SET curso=@curso
WHERE idCurso=@idCurso
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_NOTA]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MODIFICAR_NOTA]
	@idNota INTEGER,
	@notaAlumno INTEGER,
	@notaCurso INTEGER,
	@nota1 FLOAT,
	@nota2 FLOAT,
	@nota3 FLOAT,
	@nota4 FLOAT
AS
BEGIN
UPDATE Notas SET notaAlumno=@notaAlumno,notaCurso=@notaCurso,nota1=@nota1,nota2=@nota2,nota3=@nota3,nota4=@nota4
WHERE idNota=@idNota
END
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_TABLA]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_OBTENER_TABLA]
as
begin
SELECT 
idAlumnos ,
nombre ,
apellidos , 
sexo ,
numero,
email
FROM Alumnos 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_TABLA_CURSO]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_OBTENER_TABLA_CURSO]
AS
BEGIN
SELECT idCurso,curso  FROM Curso
END
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_TABLA_NOTA]    Script Date: 29/05/2020 23:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_OBTENER_TABLA_NOTA]
AS
BEGIN
SELECT N.idNota AS 'IDNOTA' ,A.apellidos AS 'APELLIDO',A.nombre AS 'NOMBRE',C.curso AS 'CURSO',N.nota1 AS 'NOTA_1',N.nota2 AS 'NOTA_2',N.nota3 AS 'NOTA_3',N.nota4 AS 'NOTA_4'
FROM Notas N INNER JOIN Alumnos A ON N.notaAlumno=A.idAlumnos
			 INNER JOIN Curso C ON N.notaCurso=C.idCurso
			 ORDER BY A.apellidos
END
GO
USE [master]
GO
ALTER DATABASE [crudAlumnos] SET  READ_WRITE 
GO

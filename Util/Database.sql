USE [master]
GO
/****** Object:  Database [Academia]    Script Date: 4/11/2018 21:46:06 ******/
CREATE DATABASE [Academia]
GO
ALTER DATABASE [Academia] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Academia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Academia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Academia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Academia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Academia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Academia] SET ARITHABORT OFF 
GO
ALTER DATABASE [Academia] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Academia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Academia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Academia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Academia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Academia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Academia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Academia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Academia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Academia] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Academia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Academia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Academia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Academia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Academia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Academia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Academia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Academia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Academia] SET  MULTI_USER 
GO
ALTER DATABASE [Academia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Academia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Academia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Academia] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Academia]
GO
/****** Object:  Table [dbo].[alumnos_inscripciones]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos_inscripciones](
	[id_inscripcion] [int] IDENTITY(1,1) NOT NULL,
	[id_alumno] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[condicion] [varchar](50) NOT NULL,
	[nota] [int] NULL,
 CONSTRAINT [PK_alumnos_inscripciones] PRIMARY KEY CLUSTERED 
(
	[id_inscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[comisiones]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comisiones](
	[id_comision] [int] IDENTITY(1,1) NOT NULL,
	[desc_comision] [varchar](50) NOT NULL,
	[anio_especialidad] [int] NOT NULL,
	[id_plan] [int] NOT NULL,
 CONSTRAINT [PK_comisiones] PRIMARY KEY CLUSTERED 
(
	[id_comision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cursos]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cursos](
	[id_curso] [int] IDENTITY(1,1) NOT NULL,
	[id_materia] [int] NOT NULL,
	[id_comision] [int] NOT NULL,
	[anio_calendario] [int] NOT NULL,
	[cupo] [int] NOT NULL,
 CONSTRAINT [PK_cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[docentes_cursos]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[docentes_cursos](
	[id_dictado] [int] IDENTITY(1,1) NOT NULL,
	[id_curso] [int] NOT NULL,
	[id_docente] [int] NOT NULL,
	[cargo] [int] NOT NULL,
 CONSTRAINT [PK_docentes_cursos] PRIMARY KEY CLUSTERED 
(
	[id_dictado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[especialidades]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[especialidades](
	[id_especialidad] [int] IDENTITY(1,1) NOT NULL,
	[desc_especialidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_especialidades] PRIMARY KEY CLUSTERED 
(
	[id_especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[materias]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[desc_materia] [varchar](50) NOT NULL,
	[hs_semanales] [int] NOT NULL,
	[hs_totales] [int] NOT NULL,
	[id_plan] [int] NOT NULL,
 CONSTRAINT [PK_materias] PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[modulos]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modulos](
	[id_modulo] [int] IDENTITY(1,1) NOT NULL,
	[desc_modulo] [varchar](50) NULL,
	[ejecuta] [varchar](50) NULL,
 CONSTRAINT [PK_modulos] PRIMARY KEY CLUSTERED 
(
	[id_modulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[modulos_usuarios]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modulos_usuarios](
	[id_modulo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_modulo] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[alta] [bit] NULL,
	[baja] [bit] NULL,
	[modificacion] [bit] NULL,
	[consulta] [bit] NULL,
 CONSTRAINT [PK_modulos_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_modulo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personas]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personas](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[fecha_nac] [datetime] NULL,
	[legajo] [int] NULL,
	[tipo_persona] [int] NULL,
	[id_plan] [int] NOT NULL,
	[email_personal] [varchar](50) NULL,
 CONSTRAINT [PK_personas] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[planes]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[planes](
	[id_plan] [int] IDENTITY(1,1) NOT NULL,
	[desc_plan] [varchar](50) NOT NULL,
	[id_especialidad] [int] NOT NULL,
	[es_plan_actual] [tinyint] NULL,
 CONSTRAINT [PK_planes] PRIMARY KEY CLUSTERED 
(
	[id_plan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[clave] [varchar](50) NOT NULL,
	[habilitado] [bit] NOT NULL,
	[cambia_clave] [bit] NULL,
	[id_persona] [int] NULL,
	[email_usuario] [varchar](50) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[alumnos_inscripciones] ON 

INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (2, 13, 8, N'Regular', 8)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (3, 13, 15, N'Regular', 5)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (10, 3, 17, N'', 9)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (13, 3, 8, N'Regular', 0)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (1013, 13, 16, N'Regular', 0)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (1014, 13, 17, N'', 0)
SET IDENTITY_INSERT [dbo].[alumnos_inscripciones] OFF
SET IDENTITY_INSERT [dbo].[comisiones] ON 

INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (1, N'ISI 101', 1, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (2, N'IQ 101', 1, 3)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (3, N'ISI 102', 1, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (4, N'ISI 201', 2, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (5, N'IQ 201', 2, 3)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (6, N'ISI 202', 2, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (7, N'ISI 301', 3, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (9, N'ISI 401', 4, 1)
SET IDENTITY_INSERT [dbo].[comisiones] OFF
SET IDENTITY_INSERT [dbo].[cursos] ON 

INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (8, 7, 1, 2018, 35)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (15, 8, 1, 2018, 35)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (16, 13, 1, 2018, 35)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (17, 14, 1, 2018, 32)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (18, 16, 7, 2018, 32)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (19, 9, 2, 2018, 31)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (20, 11, 5, 2018, 31)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (21, 10, 5, 2018, 31)
SET IDENTITY_INSERT [dbo].[cursos] OFF
SET IDENTITY_INSERT [dbo].[docentes_cursos] ON 

INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (2, 8, 1, 1)
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (3, 17, 1, 1)
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (6, 15, 1, 1)
SET IDENTITY_INSERT [dbo].[docentes_cursos] OFF
SET IDENTITY_INSERT [dbo].[especialidades] ON 

INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (1, N'Ingeniería en Sistemas de Información')
INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (2, N'Ingeniería Química')
INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (3, N'Ingeniería Mecánica')
SET IDENTITY_INSERT [dbo].[especialidades] OFF
SET IDENTITY_INSERT [dbo].[materias] ON 

INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (7, N'Álgebra y Geometría', 6, 48, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (8, N'Matemática discreta', 12, 60, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (9, N'Física I', 12, 60, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (10, N'Motores', 5, 30, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (11, N'Fisica II', 12, 98, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (13, N'Ingeniería y Sociedad', 4, 40, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (14, N'Analisis Matemático I', 6, 60, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (15, N'Análisis Matemático II', 6, 60, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (16, N'.Net', 6, 80, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (17, N'PRUEBA', 123, 123, 1)
SET IDENTITY_INSERT [dbo].[materias] OFF
SET IDENTITY_INSERT [dbo].[personas] ON 

INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [email_personal]) VALUES (1, N'Miguel', N'Oliveros Vega', N'Av Oroño 91', N'4555214', CAST(N'1980-06-02T00:00:00.000' AS DateTime), 5132, 2, 1, N'profe@hotmail.com')
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [email_personal]) VALUES (3, N'Alumno', N'McSystem', N'Av. Software 1010', N'45678213', CAST(N'1994-04-25T00:00:00.000' AS DateTime), 42122, 3, 1, N'alumno@hotmail.com')
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [email_personal]) VALUES (5, N'Admin', N'Manejo todo', N'Grosolandia 11', N'4524463', CAST(N'1990-04-05T00:00:00.000' AS DateTime), -1, 1, 1, N'eladmin@hotmail.com')
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [email_personal]) VALUES (13, N'Alumno', N'McQuimic', N'Leucositos 491', N'987654321', CAST(N'1991-12-25T00:00:00.000' AS DateTime), 422123, 3, 3, N'alumno2@hotmail.com')
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [email_personal]) VALUES (14, N'prueba', N'prueba', N'jjj2', N'564845', CAST(N'2015-02-26T00:00:00.000' AS DateTime), 23133, 3, 1, N'prueba@hotmail.com')
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [email_personal]) VALUES (15, N'Andres', N'Joaquin', N'Blvd Net 1235', N'3243424', CAST(N'1984-06-12T00:00:00.000' AS DateTime), 76543, 1, 1, N'Andresj@hotmail.com')
SET IDENTITY_INSERT [dbo].[personas] OFF
SET IDENTITY_INSERT [dbo].[planes] ON 

INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad], [es_plan_actual]) VALUES (1, N'Plan 2008', 1, NULL)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad], [es_plan_actual]) VALUES (2, N'Plan 98', 1, NULL)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad], [es_plan_actual]) VALUES (3, N'Plan 2008', 2, NULL)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad], [es_plan_actual]) VALUES (4, N'Plan 98', 2, NULL)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad], [es_plan_actual]) VALUES (5, N'Plan 2008', 3, NULL)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad], [es_plan_actual]) VALUES (6, N'Plan 98', 3, NULL)
SET IDENTITY_INSERT [dbo].[planes] OFF
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [cambia_clave], [id_persona], [email_usuario]) VALUES (1, N'admin', N'123456789', 1, NULL, 5, N'admin@frro.utn.edu.ar')
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [cambia_clave], [id_persona], [email_usuario]) VALUES (2, N'elprofe', N'123456789', 1, NULL, 1, N'prof@frro.utn.edu.ar')
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [cambia_clave], [id_persona], [email_usuario]) VALUES (6, N'alumS', N'123456789', 1, NULL, 3, N'alum@frro.utn.edu.ar')
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [cambia_clave], [id_persona], [email_usuario]) VALUES (15, N'alumQ', N'123456789', 1, NULL, 13, N'alumno2@frro.utn.edu.ar')
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [cambia_clave], [id_persona], [email_usuario]) VALUES (16, N'prueba', N'123456789', 1, NULL, 14, N'asdsda@hotmail.com')
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [cambia_clave], [id_persona], [email_usuario]) VALUES (17, N'aj', N'123456789', 1, NULL, 15, N'aj@frro.utn.edu.ar')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
/****** Object:  Index [Cu_UnicaInscripcionXAnio]    Script Date: 4/11/2018 21:46:06 ******/
ALTER TABLE [dbo].[alumnos_inscripciones] ADD  CONSTRAINT [Cu_UnicaInscripcionXAnio] UNIQUE NONCLUSTERED 
(
	[id_alumno] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UnicoCurso]    Script Date: 4/11/2018 21:46:06 ******/
ALTER TABLE [dbo].[cursos] ADD  CONSTRAINT [UnicoCurso] UNIQUE NONCLUSTERED 
(
	[id_materia] ASC,
	[id_comision] ASC,
	[anio_calendario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [usuarioUnico]    Script Date: 4/11/2018 21:46:06 ******/
ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [usuarioUnico] UNIQUE NONCLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[alumnos_inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_alumnos_inscripciones_cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[cursos] ([id_curso])
GO
ALTER TABLE [dbo].[alumnos_inscripciones] CHECK CONSTRAINT [FK_alumnos_inscripciones_cursos]
GO
ALTER TABLE [dbo].[alumnos_inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_alumnos_inscripciones_personas] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[personas] ([id_persona])
GO
ALTER TABLE [dbo].[alumnos_inscripciones] CHECK CONSTRAINT [FK_alumnos_inscripciones_personas]
GO
ALTER TABLE [dbo].[comisiones]  WITH CHECK ADD  CONSTRAINT [FK_comisiones_planes] FOREIGN KEY([id_plan])
REFERENCES [dbo].[planes] ([id_plan])
GO
ALTER TABLE [dbo].[comisiones] CHECK CONSTRAINT [FK_comisiones_planes]
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD  CONSTRAINT [FK_cursos_comisiones] FOREIGN KEY([id_comision])
REFERENCES [dbo].[comisiones] ([id_comision])
GO
ALTER TABLE [dbo].[cursos] CHECK CONSTRAINT [FK_cursos_comisiones]
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD  CONSTRAINT [FK_cursos_materias] FOREIGN KEY([id_materia])
REFERENCES [dbo].[materias] ([id_materia])
GO
ALTER TABLE [dbo].[cursos] CHECK CONSTRAINT [FK_cursos_materias]
GO
ALTER TABLE [dbo].[docentes_cursos]  WITH CHECK ADD  CONSTRAINT [FK_docentes_cursos_cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[cursos] ([id_curso])
GO
ALTER TABLE [dbo].[docentes_cursos] CHECK CONSTRAINT [FK_docentes_cursos_cursos]
GO
ALTER TABLE [dbo].[docentes_cursos]  WITH CHECK ADD  CONSTRAINT [FK_docentes_cursos_personas] FOREIGN KEY([id_docente])
REFERENCES [dbo].[personas] ([id_persona])
GO
ALTER TABLE [dbo].[docentes_cursos] CHECK CONSTRAINT [FK_docentes_cursos_personas]
GO
ALTER TABLE [dbo].[materias]  WITH CHECK ADD  CONSTRAINT [FK_materias_planes] FOREIGN KEY([id_plan])
REFERENCES [dbo].[planes] ([id_plan])
GO
ALTER TABLE [dbo].[materias] CHECK CONSTRAINT [FK_materias_planes]
GO
ALTER TABLE [dbo].[modulos_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_modulos_usuarios_modulos] FOREIGN KEY([id_modulo])
REFERENCES [dbo].[modulos] ([id_modulo])
GO
ALTER TABLE [dbo].[modulos_usuarios] CHECK CONSTRAINT [FK_modulos_usuarios_modulos]
GO
ALTER TABLE [dbo].[modulos_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_modulos_usuarios_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[modulos_usuarios] CHECK CONSTRAINT [FK_modulos_usuarios_usuarios]
GO
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_planes] FOREIGN KEY([id_plan])
REFERENCES [dbo].[planes] ([id_plan])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [FK_personas_planes]
GO
ALTER TABLE [dbo].[planes]  WITH CHECK ADD  CONSTRAINT [FK_planes_especialidades] FOREIGN KEY([id_especialidad])
REFERENCES [dbo].[especialidades] ([id_especialidad])
GO
ALTER TABLE [dbo].[planes] CHECK CONSTRAINT [FK_planes_especialidades]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[personas] ([id_persona])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_personas]
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarCurso]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarCurso]
(
	 @id_materia		int
	,@id_comision		int
	,@anio_calendario	int
	,@cupo				int
)

AS

INSERT INTO cursos
(	  id_materia
	, id_comision
	, anio_calendario
	, cupo
)
VALUES 
(
	 @id_materia
	,@id_comision
	,@anio_calendario
	,@cupo 
)

SELECT @@IDENTITY

RETURN 
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarInscripcionAlumno]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SP_AgregarInscripcionAlumno]
(
	@id_alumno varchar(50),
	@id_curso int,
	@condicion nvarchar(10),
	@nota int
)

AS

INSERT INTO [dbo].[alumnos_inscripciones]
(	id_alumno, id_curso, condicion, nota
)
VALUES 
(
	 @id_alumno
	,@id_curso
	,@condicion
	,@nota 
)

SELECT @@IDENTITY

RETURN 
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarMateria]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AgregarMateria]
(
	@desc_materia varchar(50),
	@hs_semanales int,
	@hs_totales int,
	@id_plan int
)

AS

INSERT INTO materias
(	desc_materia
	,hs_semanales
	,hs_totales
	,id_plan
)
VALUES 
(
	 @desc_materia
	,@hs_semanales
	,@hs_totales
	,@id_plan 
)

SELECT @@IDENTITY

RETURN 
GO
/****** Object:  StoredProcedure [dbo].[SP_AlumnoInscripcionesGetOne]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_AlumnoInscripcionesGetOne] 
(
	@id_inscripcionAlumno int
)
AS
SELECT id_inscripcion, i.id_alumno, i.id_curso, i.condicion, i.nota
FROM [dbo].[alumnos_inscripciones] i
inner join personas p	on p.id_persona=i.id_alumno
inner join cursos c		on c.id_curso=i.id_curso
WHERE i.id_inscripcion=@id_inscripcionAlumno

GO
/****** Object:  StoredProcedure [dbo].[SP_Alumnos_Inscripciones_GetAll]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Alumnos_Inscripciones_GetAll] 
(
	@id_persona int
)
AS
SELECT ai.id_inscripcion, ai.id_alumno , ai.id_curso, ai.condicion, ai.nota, ma.desc_materia, co.desc_Comision 
FROM personas per
INNER JOIN planes pl	 ON pl.id_plan=per.id_plan   --se puede ir directamente desde personas a comisiones
INNER JOIN comisiones co ON co.id_plan=pl.id_plan
INNER JOIN cursos cu	 ON cu.id_comision=co.id_comision
INNER JOIN materias ma	 ON ma.id_materia=cu.id_materia
INNER JOIN alumnos_inscripciones ai ON ai.id_alumno=per.id_persona
									AND ai.id_curso=cu.id_curso 
WHERE per.id_persona = @id_persona
GO
/****** Object:  StoredProcedure [dbo].[SP_Cursos]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_Cursos]
AS
SELECT    cur.id_curso
		, cur.id_materia
		, cur.id_comision
		, cur.anio_calendario
		, cur.cupo
		, mat.[desc_materia]
		, mat.hs_semanales
		, mat.hs_totales
		, mat.id_plan				as mat_id_plan
		, com.desc_comision
		, com.anio_especialidad
		, com.id_plan				as com_id_plan
		,COUNT(AI.id_inscripcion) OVER (PARTITION BY AI.ID_CURSO ORDER BY AI.ID_CURSO) AS CANTIDAD_DE_INSCRIPTOS
		,AI.apellido
		,AI.nombre
		,AI.nota
		,AI.condicion
FROM cursos	cur
	INNER JOIN materias		mat	on mat.id_materia=cur.id_materia
	INNER JOIN comisiones	com on com.id_comision=cur.id_comision
	LEFT JOIN (select * from alumnos_inscripciones  ai inner join personas p on p.id_persona=ai.id_alumno) AI ON AI.id_curso=cur.id_curso
				

				
GO
/****** Object:  StoredProcedure [dbo].[SP_CursosGetAll]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CursosGetAll]
AS
SELECT    cur.id_curso
		, cur.id_materia
		, cur.id_comision
		, cur.anio_calendario
		, cur.cupo
		, mat.[desc_materia]
		, mat.hs_semanales
		, mat.hs_totales
		, mat.id_plan				as mat_id_plan
		, com.desc_comision
		, com.anio_especialidad
		, com.id_plan				as com_id_plan
		
FROM cursos	cur
	INNER JOIN materias		mat	on mat.id_materia=cur.id_materia
	INNER JOIN comisiones	com on com.id_comision=cur.id_comision

GO
/****** Object:  StoredProcedure [dbo].[SP_CursosGetOne]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CursosGetOne] 
(
	@id_curso int
)
AS
SELECT    cur.id_curso
		, cur.id_materia
		, cur.id_comision
		, cur.anio_calendario
		, cur.cupo
		, mat.[desc_materia]
		, mat.hs_semanales
		, mat.hs_totales
		, mat.id_plan				as mat_id_plan
		, com.desc_comision
		, com.anio_especialidad
		, com.id_plan				as com_id_plan
FROM cursos	cur
	INNER JOIN materias		mat	on mat.id_materia=cur.id_materia
	INNER JOIN comisiones	com on com.id_comision=cur.id_comision
WHERE id_curso=@id_curso
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCurso]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteCurso]
(
	@id_curso int
)

AS

DELETE FROM cursos
WHERE id_curso=@id_curso
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteInscripcionAlumno]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_DeleteInscripcionAlumno]
(
	@id_inscripcion int
)

AS

DELETE FROM [dbo].[alumnos_inscripciones]
WHERE id_inscripcion=@id_inscripcion

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteMateria]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteMateria]
(
	@id_materia int
)

AS

DELETE FROM materias
WHERE id_materia=@id_materia

GO
/****** Object:  StoredProcedure [dbo].[SP_MateriasGetAll]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MateriasGetAll]
AS
SELECT m.id_materia, m.desc_materia, m.hs_semanales, m.hs_totales, p.id_plan, p.desc_plan, e.id_especialidad, e.desc_especialidad
FROM [dbo].[materias] m
	INNER JOIN planes p ON p.id_plan=m.id_plan
	INNER JOIN especialidades e ON e.id_especialidad=p.id_especialidad

GO
/****** Object:  StoredProcedure [dbo].[SP_MateriasGetOne]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MateriasGetOne] 
(
	@id_materia int
)
AS
SELECT m.id_materia, m.desc_materia, m.hs_semanales, m.hs_totales, p.id_plan, p.desc_plan, e.id_especialidad, e.desc_especialidad
FROM [dbo].[materias] m
	INNER JOIN planes p ON p.id_plan=m.id_plan
	INNER JOIN especialidades e ON e.id_especialidad=p.id_especialidad
WHERE id_materia=@id_materia
GO
/****** Object:  StoredProcedure [dbo].[SP_Planes]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_Planes]
AS
SELECT																 
 p.id_plan															 
,p.desc_plan														 
,e.id_especialidad													 
,e.desc_especialidad												 
FROM planes p														 
INNER JOIN especialidades e ON e.id_especialidad = P.id_especialidad 

				
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCurso]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateCurso]
(
	 @id_curso			int
	,@id_materia		int
	,@id_comision		int
	,@anio_calendario	int
	,@cupo				int
)

AS

UPDATE cursos
SET	id_materia			= @id_materia		
	,id_comision		= @id_comision		
	,anio_calendario	= @anio_calendario	
	,cupo				= @cupo				
WHERE id_curso=@id_curso
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateInscripcionAlumno]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create PROCEDURE [dbo].[SP_UpdateInscripcionAlumno]
(
	@id_inscripcion	int ,
	@id_alumno	  int ,
	@id_curso	  int ,
	@condicion	nvarchar(10),
	@nota		int
)

AS

UPDATE [dbo].[alumnos_inscripciones]
SET	 id_alumno		  =@id_alumno	
, id_curso		  =@id_curso	
, condicion		  =@condicion	
, nota			  =@nota		


WHERE id_inscripcion=@id_inscripcion
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateMateria]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateMateria]
(
	@id_materia int,
	@desc_materia varchar(50),
	@hs_semanales int,
	@hs_totales int,
	@id_plan int
)

AS

UPDATE materias
SET	desc_materia =@desc_materia
	,hs_semanales=@hs_semanales
	,hs_totales	 =@hs_totales
	,id_plan	 =@id_plan
WHERE id_materia=@id_materia
GO
/****** Object:  StoredProcedure [dbo].[UsuarioGetAll]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UsuarioGetAll] 
AS
SELECT  id_usuario, 
		nombre_usuario, 
		clave, 
		habilitado, 
		nombre, 
		apellido, 
		email, 
		cambia_clave, 
		id_persona
FROM usuarios

GO
/****** Object:  StoredProcedure [dbo].[UsuarioGetOne]    Script Date: 4/11/2018 21:46:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UsuarioGetOne] (@Id int)
AS
SELECT  id_usuario, 
		nombre_usuario, 
		clave, 
		habilitado, 
		nombre, 
		apellido, 
		email, 
		cambia_clave, 
		id_persona
FROM usuarios 
WHERE id_usuario = @id

GO
USE [master]
GO
ALTER DATABASE [Academia] SET  READ_WRITE 
GO

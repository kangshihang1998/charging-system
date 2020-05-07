/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2020/1/29 22:43:20                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CancelCard') and o.name = 'FK_CANCELCA_REFERENCE_REGISTRA')
alter table CancelCard
   drop constraint FK_CANCELCA_REFERENCE_REGISTRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LineStudent') and o.name = 'FK_LINESTUD_REFERENCE_REGISTRA')
alter table LineStudent
   drop constraint FK_LINESTUD_REFERENCE_REGISTRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ManIDcardno') and o.name = 'FK_MANIDCAR_REFERENCE_MANAGERI')
alter table ManIDcardno
   drop constraint FK_MANIDCAR_REFERENCE_MANAGERI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Managerial') and o.name = 'FK_MANAGERI_REFERENCE_USERLONI')
alter table Managerial
   drop constraint FK_MANAGERI_REFERENCE_USERLONI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OnLineStudent') and o.name = 'FK_ONLINEST_REFERENCE_REGISTRA')
alter table OnLineStudent
   drop constraint FK_ONLINEST_REFERENCE_REGISTRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OnWorkMan') and o.name = 'FK_ONWORKMA_REFERENCE_MANAGERI')
alter table OnWorkMan
   drop constraint FK_ONWORKMA_REFERENCE_MANAGERI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OpertionWork') and o.name = 'FK_OPERTION_REFERENCE_MANAGERI')
alter table OpertionWork
   drop constraint FK_OPERTION_REFERENCE_MANAGERI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Recharge') and o.name = 'FK_RECHARGE_REFERENCE_REGISTRA')
alter table Recharge
   drop constraint FK_RECHARGE_REFERENCE_REGISTRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RegistrationCardno') and o.name = 'FK_REGISTRA_REFERENCE_USERLONI')
alter table RegistrationCardno
   drop constraint FK_REGISTRA_REFERENCE_USERLONI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StudentInfo') and o.name = 'FK_STUDENTI_REFERENCE_REGISTRA')
alter table StudentInfo
   drop constraint FK_STUDENTI_REFERENCE_REGISTRA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Basis')
            and   type = 'U')
   drop table Basis
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CancelCard')
            and   type = 'U')
   drop table CancelCard
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"Check"')
            and   type = 'U')
   drop table "Check"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LineStudent')
            and   type = 'U')
   drop table LineStudent
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ManIDcardno')
            and   type = 'U')
   drop table ManIDcardno
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Managerial')
            and   type = 'U')
   drop table Managerial
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OnLineStudent')
            and   type = 'U')
   drop table OnLineStudent
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OnWorkMan')
            and   type = 'U')
   drop table OnWorkMan
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OpertionWork')
            and   type = 'U')
   drop table OpertionWork
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Recharge')
            and   type = 'U')
   drop table Recharge
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RegistrationCardno')
            and   type = 'U')
   drop table RegistrationCardno
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StudentInfo')
            and   type = 'U')
   drop table StudentInfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UserLonin')
            and   type = 'U')
   drop table UserLonin
go

/*==============================================================*/
/* Table: Basis                                                 */
/*==============================================================*/
create table Basis (
   LimtOnCash           money                not null,
   LimtReCash           money                not null,
   OnpreTime            time                 not null,
   FixUser              money                not null,
   TemUser              money                not null
)
go

/*==============================================================*/
/* Table: CancelCard                                            */
/*==============================================================*/
create table CancelCard (
   StudentCardno        int                  not null,
   CanCash              money                not null,
   CanDate              date                 not null,
   CanTime              time                 not null,
   OperationID          int                  not null,
   State                varchar(6)           not null,
   constraint PK_CANCELCARD primary key (StudentCardno)
)
go

/*==============================================================*/
/* Table: "Check"                                               */
/*==============================================================*/
create table "Check" (
   SallCash             money                not null,
   RechargeCash         money                not null,
   CanCash              money                not null,
   "current income"     money                not null,
   Opertion             int                  not null,
   checkDate            date                 not null,
   constraint PK_CHECK primary key (checkDate)
)
go

/*==============================================================*/
/* Table: LineStudent                                           */
/*==============================================================*/
create table LineStudent (
   StudentCardno        int                  not null,
   StudentName          varchar(6)           not null,
   StudentLevel         varchar(12)          not null,
   OnDate               date                 not null,
   OnTime               time                 not null,
   "UpDate"             date                 not null,
   UpTime               time                 not null,
   OnLineMin            time                 not null,
   ConsumptionCash      money                not null,
   NowCash              money                not null,
   constraint PK_LINESTUDENT primary key (StudentCardno)
)
go

/*==============================================================*/
/* Table: ManIDcardno                                           */
/*==============================================================*/
create table ManIDcardno (
   ManID                int                  not null,
   PhoneNumber          int                  not null,
   "E-mail address"     varchar(18)          not null,
   "Home Address"       varchar(30)          not null,
   IdCardno             varchar(18)          not null,
   constraint PK_MANIDCARDNO primary key (ManID)
)
go

/*==============================================================*/
/* Table: Managerial                                            */
/*==============================================================*/
create table Managerial (
   ManID                int                  not null,
   Pwd                  varchar(12)          not null,
   Name                 varchar(12)          not null,
   Sex                  varchar(2)           not null,
   Age                  int                  not null,
   Level                varchar(6)           not null,
   State                varchar(6)           not null,
   constraint PK_MANAGERIAL primary key (ManID)
)
go

/*==============================================================*/
/* Table: OnLineStudent                                         */
/*==============================================================*/
create table OnLineStudent (
   StudentCardno        int                  not null,
   StudentName          varchar(6)           not null,
   StudentLevel         varchar(12)          not null,
   OnDate               date                 not null,
   OnTime               time                 not null,
   constraint PK_ONLINESTUDENT primary key (StudentCardno)
)
go

/*==============================================================*/
/* Table: OnWorkMan                                             */
/*==============================================================*/
create table OnWorkMan (
   ManID                int                  not null,
   ManLevel             varchar(6)           not null,
   OpertionName         varchar(6)           not null,
   OnDate               date                 not null,
   OnTime               time                 not null,
   constraint PK_ONWORKMAN primary key (ManID)
)
go

/*==============================================================*/
/* Table: OpertionWork                                          */
/*==============================================================*/
create table OpertionWork (
   ManID                int                  not null,
   ManLevel             varchar(6)           not null,
   ManName              varchar(6)           not null,
   OnDate               date                 not null,
   OnTime               time                 not null,
   "UpDate"             date                 not null,
   UpTime               time                 not null,
   constraint PK_OPERTIONWORK primary key (ManID)
)
go

/*==============================================================*/
/* Table: Recharge                                              */
/*==============================================================*/
create table Recharge (
   StudentCardno        int                  not null,
   RechargeCash         money                not null,
   RechargeDate         date                 not null,
   RechargeTime         time                 not null,
   OPertonID            int                  not null,
   State                varchar(6)           not null,
   constraint PK_RECHARGE primary key (StudentCardno)
)
go

/*==============================================================*/
/* Table: RegistrationCardno                                    */
/*==============================================================*/
create table RegistrationCardno (
   StudentCardno        int                  not null,
   StudentPwd           varchar(12)          not null,
   Studentbalance       money                not null,
   Initialamount        money                not null,
   StudentLeve          varchar(12)          not null,
   State                varchar(6)           not null,
   constraint PK_REGISTRATIONCARDNO primary key (StudentCardno)
)
go

/*==============================================================*/
/* Table: StudentInfo                                           */
/*==============================================================*/
create table StudentInfo (
   StudentCardno        int                  not null,
   Name                 varchar(12)          not null,
   Sex                  varchar(2)           not null,
   Age                  int                  not null,
   CallNumber           varchar(11)          not null,
   WeChat               varchar(18)          null,
   "E-mail address"     varchar(18)          null,
   "Home Address"       varchar(30)          not null,
   Grade                varchar(4)           not null,
   constraint PK_STUDENTINFO primary key (StudentCardno)
)
go

/*==============================================================*/
/* Table: UserLonin                                             */
/*==============================================================*/
create table UserLonin (
   UserID               int                  not null,
   UserLevel            varchar(6)           not null,
   constraint PK_USERLONIN primary key (UserID)
)
go

alter table CancelCard
   add constraint FK_CANCELCA_REFERENCE_REGISTRA foreign key (StudentCardno)
      references RegistrationCardno (StudentCardno)
go

alter table LineStudent
   add constraint FK_LINESTUD_REFERENCE_REGISTRA foreign key (StudentCardno)
      references RegistrationCardno (StudentCardno)
go

alter table ManIDcardno
   add constraint FK_MANIDCAR_REFERENCE_MANAGERI foreign key (ManID)
      references Managerial (ManID)
go

alter table Managerial
   add constraint FK_MANAGERI_REFERENCE_USERLONI foreign key (ManID)
      references UserLonin (UserID)
go

alter table OnLineStudent
   add constraint FK_ONLINEST_REFERENCE_REGISTRA foreign key (StudentCardno)
      references RegistrationCardno (StudentCardno)
go

alter table OnWorkMan
   add constraint FK_ONWORKMA_REFERENCE_MANAGERI foreign key (ManID)
      references Managerial (ManID)
go

alter table OpertionWork
   add constraint FK_OPERTION_REFERENCE_MANAGERI foreign key (ManID)
      references Managerial (ManID)
go

alter table Recharge
   add constraint FK_RECHARGE_REFERENCE_REGISTRA foreign key (StudentCardno)
      references RegistrationCardno (StudentCardno)
go

alter table RegistrationCardno
   add constraint FK_REGISTRA_REFERENCE_USERLONI foreign key (StudentCardno)
      references UserLonin (UserID)
go

alter table StudentInfo
   add constraint FK_STUDENTI_REFERENCE_REGISTRA foreign key (StudentCardno)
      references RegistrationCardno (StudentCardno)
go


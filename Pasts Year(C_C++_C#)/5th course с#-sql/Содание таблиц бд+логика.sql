/*==============================================================*/
/* DBMS name:      ORACLE Version 10gR2                         */
/* Created on:     13.01.2013 13:14:07                          */
/*==============================================================*/
-- Type package declaration
create or replace package PDTypes  
as
    TYPE ref_cursor IS REF CURSOR;
end;

-- Integrity package declaration
create or replace package IntegrityPackage AS
 procedure InitNestLevel;
 function GetNestLevel return number;
 procedure NextNestLevel;
 procedure PreviousNestLevel;
 end IntegrityPackage;
/

-- Integrity package definition
create or replace package body IntegrityPackage AS
 NestLevel number;

-- Procedure to initialize the trigger nest level
 procedure InitNestLevel is
 begin
 NestLevel := 0;
 end;


-- Function to return the trigger nest level
 function GetNestLevel return number is
 begin
 if NestLevel is null then
     NestLevel := 0;
 end if;
 return(NestLevel);
 end;

-- Procedure to increase the trigger nest level
 procedure NextNestLevel is
 begin
 if NestLevel is null then
     NestLevel := 0;
 end if;
 NestLevel := NestLevel + 1;
 end;

-- Procedure to decrease the trigger nest level
 procedure PreviousNestLevel is
 begin
 NestLevel := NestLevel - 1;
 end;

 end IntegrityPackage;
/


drop trigger "tib_t_in_prikaz"
/

drop trigger "tib_t_in_prikaz_pov_kv"
/

drop trigger "tib_t_in_pr_att_komm"
/

drop trigger "tib_t_in_rez_test"
/

drop trigger "tib_t_in_svid_pov_kv"
/

drop trigger "tib_t_in_trud_dog"
/

drop trigger "tib_t_in_ved_ob_rab"
/

drop trigger "tib_t_in_ved_zat_tr"
/

drop trigger "tib_t_in_zayav_pov_kv"
/

drop trigger "tib_t_spr_dolj"
/

drop trigger "tib_t_spr_norm_att"
/

drop trigger "tib_t_spr_org"
/

drop trigger "tib_t_spr_podr"
/

drop trigger "tib_t_spr_sotr"
/

drop trigger "tib_t_spr_theme"
/

drop trigger "tib_t_spr_vid_rab"
/

alter table T_IN_PRIKAZ
   drop constraint FK_T_IN_PRI_REFERENCE_T_SPR_SO
/

alter table T_IN_PRIKAZ
   drop constraint FK_T_IN_PRI_REFERENCE_T_SPR_PO
/

alter table T_IN_PRIKAZ_POV_KV
   drop constraint FK_T_IN_PRI_REFERENCE_T_SPR_OR
/

alter table T_IN_PRIKAZ_POV_KV
   drop constraint FK_T_IN_PRI_REFERENCE_T_IN_ZAY
/

alter table T_IN_PR_ATT_KOMM
   drop constraint FK_T_IN_PR__REFERENCE_T_SPR_SO
/

alter table T_IN_REZ_TEST
   drop constraint FK_T_IN_REZ_REFERENCE_T_SPR_SO
/

alter table T_IN_SVID_POV_KV
   drop constraint FK_T_IN_SVI_REFERENCE_T_IN_PRI
/

alter table T_IN_TRUD_DOG
   drop constraint FK_T_IN_TRU_REFERENCE_T_SPR_SO
/

alter table T_IN_VED_OB_RAB
   drop constraint FK_T_IN_V_O_R_REF_T_S_V_R
/

alter table T_IN_VED_ZAT_TR
   drop constraint FK_T_I_V_Z_T_REF_T_S_V_R
/

alter table T_IN_ZAYAV_POV_KV
   drop constraint FK_T_IN_ZAY_REFERENCE_T_SPR_TH
/

alter table T_IN_ZAYAV_POV_KV
   drop constraint FK_T_IN_ZAY_REFERENCE_T_SPR_SO
/

alter table T_SPR_DOLJ
   drop constraint FK_T_SPR_DO_REFERENCE_T_SPR_PO
/

alter table T_SPR_NORM_ATT
   drop constraint FK_T_SPR_NO_REFERENCE_T_SPR_DO
/

alter table T_SPR_OB_DEN_SR
   drop constraint FK_T_SPR_OB_REFERENCE_T_YEARS
/

alter table T_SPR_ORG
   drop constraint FK_T_SPR_OR_REFERENCE_T_SPR_TH
/

alter table T_SPR_SOTR
   drop constraint FK_T_SPR_SO_REFERENCE_T_SPR_DO
/

alter table T_SPR_VID_RAB
   drop constraint FK_T_SPR_VI_REFERENCE_T_SPR_DO
/

drop view V_IN_PRIKAZ_NAIM
/

drop view V_IN_PRIKAZ_PEREVOD
/

drop view V_IN_PRIKAZ_POV_KV
/

drop view V_IN_PRIKAZ_UVOL
/

drop view V_IN_PR_ATT_KOMM
/

drop view V_IN_REZ_TEST
/

drop view V_OUT_GRAF_POV_KV
/

drop view V_IN_SVID_POV_KV
/

drop view V_IN_TRUD_DOG
/

drop view V_IN_UCH_SOTR
/

drop view V_IN_ZAYAV_POV_KV
/

drop view V_OUT_CONTROL_GRAF_POV_KV
/

drop view V_OUT_PLAN_ATT
/

drop view V_OUT_OTCHET_PLAN_ATT
/

drop view V_OUT_SHTAT_RASP
/

drop view V_OUT_VED_DV_KADR
/

drop view V_OUT_VED_POTR_KADR
/

drop view V_SPR_DOLJ
/

drop view V_SPR_NORM_ATT
/

drop view V_SPR_ORG
/

drop view V_SPR_PODR
/

drop view V_SPR_SOTR
/

drop view V_SPR_VID_RAB
/

drop view V_IN_VED_OB_RAB
/

drop view V_IN_VED_ZAT_TR
/

alter table T_IN_PRIKAZ
   drop primary key cascade
/

drop table T_IN_PRIKAZ cascade constraints
/

alter table T_IN_PRIKAZ_POV_KV
   drop primary key cascade
/

drop table T_IN_PRIKAZ_POV_KV cascade constraints
/

alter table T_IN_PR_ATT_KOMM
   drop primary key cascade
/

drop table T_IN_PR_ATT_KOMM cascade constraints
/

alter table T_IN_REZ_TEST
   drop primary key cascade
/

drop table T_IN_REZ_TEST cascade constraints
/

alter table T_IN_SVID_POV_KV
   drop primary key cascade
/

drop table T_IN_SVID_POV_KV cascade constraints
/

alter table T_IN_TRUD_DOG
   drop primary key cascade
/

drop table T_IN_TRUD_DOG cascade constraints
/

alter table T_IN_VED_OB_RAB
   drop primary key cascade
/

drop table T_IN_VED_OB_RAB cascade constraints
/

alter table T_IN_VED_ZAT_TR
   drop primary key cascade
/

drop table T_IN_VED_ZAT_TR cascade constraints
/

alter table T_IN_ZAYAV_POV_KV
   drop primary key cascade
/

drop table T_IN_ZAYAV_POV_KV cascade constraints
/

alter table T_SPR_DOLJ
   drop primary key cascade
/

drop table T_SPR_DOLJ cascade constraints
/

alter table T_SPR_NORM_ATT
   drop primary key cascade
/

drop table T_SPR_NORM_ATT cascade constraints
/

alter table T_SPR_OB_DEN_SR
   drop primary key cascade
/

drop table T_SPR_OB_DEN_SR cascade constraints
/

alter table T_SPR_ORG
   drop primary key cascade
/

drop table T_SPR_ORG cascade constraints
/

alter table T_SPR_PODR
   drop primary key cascade
/

drop table T_SPR_PODR cascade constraints
/

alter table T_SPR_SOTR
   drop primary key cascade
/

drop table T_SPR_SOTR cascade constraints
/

alter table T_SPR_THEME
   drop primary key cascade
/

drop table T_SPR_THEME cascade constraints
/

alter table T_SPR_VID_RAB
   drop primary key cascade
/

drop table T_SPR_VID_RAB cascade constraints
/

alter table T_YEARS
   drop primary key cascade
/

drop table T_YEARS cascade constraints
/


drop sequence IDENTSEQUENCE;
create sequence IDENTSEQUENCE
increment by 1
start with 1
 nomaxvalue
 nominvalue
 nocache
order;

/*==============================================================*/
/* Table: T_IN_PRIKAZ                                           */
/*==============================================================*/
create table T_IN_PRIKAZ  (
   ID_PRIKAZ            NUMBER(6)                       not null,
   ID_SOTR              INTEGER,
   ID_PODR              INTEGER,
   DATE_PR              DATE,
   PRICHINA             VARCHAR(100),
   PRIKAZ_TYPE          INTEGER,
   constraint PK_T_IN_PRIKAZ primary key (ID_PRIKAZ)
);

/*==============================================================*/
/* Table: T_IN_PRIKAZ_POV_KV                                    */
/*==============================================================*/
create table T_IN_PRIKAZ_POV_KV  (
   ID_PRIKAZ            NUMBER(6)                       not null,
   ID_ORG               INTEGER,
   ID_ZAYAV             INTEGER,
   constraint PK_T_IN_PRIKAZ_POV_KV primary key (ID_PRIKAZ)
);

/*==============================================================*/
/* Table: T_IN_PR_ATT_KOMM                                      */
/*==============================================================*/
create table T_IN_PR_ATT_KOMM  (
   ID_PROT              NUMBER(6)                       not null,
   ID_SOTR              INTEGER,
   DATE_ATT             DATE,
   MINBALL              INTEGER,
   BALL                 INTEGER,
   constraint PK_T_IN_PR_ATT_KOMM primary key (ID_PROT)
);

/*==============================================================*/
/* Table: T_IN_REZ_TEST                                         */
/*==============================================================*/
create table T_IN_REZ_TEST  (
   ID_REZ_TEST          NUMBER(6)                       not null,
   ID_SOTR              INTEGER,
   BALL                 NUMERIC(18, 2),
   PROHOD_BALL          NUMERIC(18, 2),
   constraint PK_T_IN_REZ_TEST primary key (ID_REZ_TEST)
);

/*==============================================================*/
/* Table: T_IN_SVID_POV_KV                                      */
/*==============================================================*/
create table T_IN_SVID_POV_KV  (
   ID_SVID              NUMBER(6)                       not null,
   ID_PRIKAZ            INTEGER,
   FACT_DATE            DATE,
   DOC_NAME             VARCHAR(100),
   constraint PK_T_IN_SVID_POV_KV primary key (ID_SVID)
);

/*==============================================================*/
/* Table: T_IN_TRUD_DOG                                         */
/*==============================================================*/
create table T_IN_TRUD_DOG  (
   ID_TRUD_DOG          NUMBER(6)                       not null,
   ID_SOTR              INTEGER,
   OKLAD                NUMERIC(18, 2),
   NADB                 NUMERIC(18, 2),
   PR_VYPL              NUMERIC(18, 2),
   constraint PK_T_IN_TRUD_DOG primary key (ID_TRUD_DOG)
);

/*==============================================================*/
/* Table: T_IN_VED_OB_RAB                                       */
/*==============================================================*/
create table T_IN_VED_OB_RAB  (
   ID_VED_OB_RAB        NUMBER(6)                       not null,
   ID_VID_RAB           INTEGER,
   KOLVO                NUMERIC(18, 2),
   START_DATE           DATE,
   FINISH_DATE          DATE,
   constraint PK_T_IN_VED_OB_RAB primary key (ID_VED_OB_RAB)
);

/*==============================================================*/
/* Table: T_IN_VED_ZAT_TR                                       */
/*==============================================================*/
create table T_IN_VED_ZAT_TR  (
   ID_VED_ZAT_TR        NUMBER(6)                       not null,
   ID_VID_RAB           INTEGER,
   VR_NORM              NUMBER(18,2),
   CHEL_CH              NUMBER(18,2),
   CHEL_DN              NUMBER(18,2),
   constraint PK_T_IN_VED_ZAT_TR primary key (ID_VED_ZAT_TR)
);

/*==============================================================*/
/* Table: T_IN_ZAYAV_POV_KV                                     */
/*==============================================================*/
create table T_IN_ZAYAV_POV_KV  (
   ID_ZAYAV             NUMBER(6)                       not null,
   ID_THEME             INTEGER,
   ID_SOTR              INTEGER,
   SRO                  VARCHAR(100),
   constraint PK_T_IN_ZAYAV_POV_KV primary key (ID_ZAYAV)
);

/*==============================================================*/
/* Table: T_SPR_DOLJ                                            */
/*==============================================================*/
create table T_SPR_DOLJ  (
   ID_DOLJ              NUMBER(6)                       not null,
   ID_PODR              INTEGER,
   NAME                 VARCHAR(100),
   constraint PK_T_SPR_DOLJ primary key (ID_DOLJ)
);

/*==============================================================*/
/* Table: T_SPR_NORM_ATT                                        */
/*==============================================================*/
create table T_SPR_NORM_ATT  (
   ID_NORM              NUMBER(6)                       not null,
   ID_DOLJ              INTEGER,
   PERIOD               INTEGER,
   constraint PK_T_SPR_NORM_ATT primary key (ID_NORM)
);

/*==============================================================*/
/* Table: T_SPR_OB_DEN_SR                                       */
/*==============================================================*/
create table T_SPR_OB_DEN_SR  (
   YEAR                 INTEGER                         not null,
   RAZM_OPL             NUMERIC(18, 2),
   constraint PK_T_SPR_OB_DEN_SR primary key (YEAR)
);

/*==============================================================*/
/* Table: T_SPR_ORG                                             */
/*==============================================================*/
create table T_SPR_ORG  (
   ID_ORG               NUMBER(6)                       not null,
   ID_THEME             INTEGER,
   NAME                 VARCHAR(100),
   DATE_PROV            DATE,
   COST                 NUMERIC(18, 2),
   constraint PK_T_SPR_ORG primary key (ID_ORG)
);

/*==============================================================*/
/* Table: T_SPR_PODR                                            */
/*==============================================================*/
create table T_SPR_PODR  (
   ID_PODR              NUMBER(6)                       not null,
   NAME                 VARCHAR(100),
   constraint PK_T_SPR_PODR primary key (ID_PODR)
);

/*==============================================================*/
/* Table: T_SPR_SOTR                                            */
/*==============================================================*/
create table T_SPR_SOTR  (
   ID_SOTR              NUMBER(6)                       not null,
   ID_DOLJ              INTEGER,
   NAME                 VARCHAR(100),
   STAJ                 INTEGER,
   DATE_PRIEM           DATE,
   LAST_ATT_DATE        DATE,
   constraint PK_T_SPR_SOTR primary key (ID_SOTR)
);

/*==============================================================*/
/* Table: T_SPR_THEME                                           */
/*==============================================================*/
create table T_SPR_THEME  (
   ID_THEME             NUMBER(6)                       not null,
   NAME                 VARCHAR(100),
   constraint PK_T_SPR_THEME primary key (ID_THEME)
);

/*==============================================================*/
/* Table: T_SPR_VID_RAB                                         */
/*==============================================================*/
create table T_SPR_VID_RAB  (
   ID_VID_RAB           NUMBER(6)                       not null,
   ID_DOLJ              INTEGER,
   NAME                 VARCHAR(100),
   ED_IZM               VARCHAR(100),
   constraint PK_T_SPR_VID_RAB primary key (ID_VID_RAB)
);

/*==============================================================*/
/* Table: T_YEARS                                               */
/*==============================================================*/
create table T_YEARS  (
   YEAR                 INTEGER                         not null,
   constraint PK_T_YEARS primary key (YEAR)
);

/*==============================================================*/
/* View: V_IN_PRIKAZ_NAIM                                       */
/*==============================================================*/
create or replace view V_IN_PRIKAZ_NAIM as
select
   A.NAME PODR_NAME,
   B.NAME DOLJ_NAME,
   C.ID_SOTR,
   C.NAME SOTR_NAME,
   C.DATE_PRIEM,
   D.ID_PRIKAZ,
   D.DATE_PR,
   B.ID_DOLJ
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_SOTR C,
   T_IN_PRIKAZ D
 WHERE A.ID_PODR = B.ID_PODR AND
 B.ID_DOLJ = C.ID_DOLJ AND
 C.ID_SOTR = D.ID_SOTR AND D.PRIKAZ_TYPE = 0
with read only;

/*==============================================================*/
/* View: V_IN_PRIKAZ_PEREVOD                                    */
/*==============================================================*/
create or replace view V_IN_PRIKAZ_PEREVOD as
select
   A.NAME NEW_PODR_NAME,
   B.NAME DOLJ_NAME,
   C.ID_SOTR,
   C.NAME SOTR_NAME,
   D.ID_PRIKAZ,
   D.ID_PODR ID_OLD_PODR,
   E.NAME OLD_PODR_NAME,
   D.DATE_PR,
   B.ID_DOLJ
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_SOTR C,
   T_IN_PRIKAZ D,
   T_SPR_PODR E
 WHERE A.ID_PODR = B.ID_PODR AND
 B.ID_DOLJ = C.ID_DOLJ AND
 C.ID_SOTR = D.ID_SOTR AND D.PRIKAZ_TYPE = 1 
 and E.ID_PODR = D.ID_PODR
with read only;

/*==============================================================*/
/* View: V_SPR_SOTR                                             */
/*==============================================================*/
create or replace view V_SPR_SOTR as
select
   A.ID_PODR ID_PODR,
   A.NAME PODR_NAME,
   B.ID_DOLJ ID_DOLJ,
   B.NAME DOLJ_NAME,
   C.ID_SOTR,
   C.NAME SOTR_NAME,
   C.STAJ
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_SOTR C
WHERE A.ID_PODR = B.ID_PODR AND B.ID_DOLJ = C.ID_DOLJ
with read only;


/*==============================================================*/
/* View: V_IN_ZAYAV_POV_KV                                      */
/*==============================================================*/
create or replace view V_IN_ZAYAV_POV_KV as
select
   A.ID_THEME ID_THEME,
   A.NAME THEME_NAME,
   B.ID_ZAYAV,
   B.SRO,
   C.ID_PODR,
   C.PODR_NAME,
   C.ID_DOLJ,
   C.DOLJ_NAME,
   C.ID_SOTR,
   C.SOTR_NAME
from
   T_SPR_THEME A,
   T_IN_ZAYAV_POV_KV B,
   V_SPR_SOTR C
WHERE A.ID_THEME = B.ID_THEME AND B.ID_SOTR = C.ID_SOTR
with read only;



/*==============================================================*/
/* View: V_IN_PRIKAZ_POV_KV                                     */
/*==============================================================*/
create or replace view V_IN_PRIKAZ_POV_KV as
select
   A.ID_PRIKAZ,
   A.ID_ORG,
   A.ID_ZAYAV,
   B.ID_THEME,
   B.THEME_NAME,
   B.SRO,
   B.ID_PODR,
   B.PODR_NAME,
   B.ID_DOLJ,
   B.DOLJ_NAME,
   B.ID_SOTR,
   B.SOTR_NAME
from
   T_IN_PRIKAZ_POV_KV A,
   V_IN_ZAYAV_POV_KV B
WHERE A.ID_ZAYAV = B.ID_ZAYAV
with read only;

/*==============================================================*/
/* View: V_IN_PRIKAZ_UVOL                                       */
/*==============================================================*/
create or replace view V_IN_PRIKAZ_UVOL as
select
   A.NAME PODR_NAME,
   B.NAME DOLJ_NAME,
   C.ID_SOTR,
   C.NAME SOTR_NAME,
   D.ID_PRIKAZ,
   D.DATE_PR,
   D.PRICHINA,
   B.ID_DOLJ
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_SOTR C,
   T_IN_PRIKAZ D
 WHERE A.ID_PODR = B.ID_PODR AND
 B.ID_DOLJ = C.ID_DOLJ AND
 C.ID_SOTR = D.ID_SOTR AND D.PRIKAZ_TYPE = 2
with read only;

/*==============================================================*/
/* View: V_IN_PR_ATT_KOMM                                       */
/*==============================================================*/
create or replace view V_IN_PR_ATT_KOMM as
select
   A.ID_PODR,
   A.NAME PODR_NAME,
   B.ID_DOLJ,
   B.NAME DOLJ_NAME,
   C.ID_SOTR,
   C.NAME SOTR_NAME,
   D.ID_PROT,
   D.DATE_ATT,
   D.MINBALL,
   D.BALL
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_SOTR C,
   T_IN_PR_ATT_KOMM D
   WHERE A.ID_PODR = B.ID_PODR AND
   B.ID_DOLJ = C.ID_DOLJ AND C.ID_SOTR = D.ID_SOTR
with read only;

/*==============================================================*/
/* View: V_IN_REZ_TEST                                          */
/*==============================================================*/
create or replace view V_IN_REZ_TEST as
select
   A.NAME PODR_NAME,
   B.NAME DOLJ_NAME,
   C.ID_SOTR,
   C.NAME T_SPR_SOTR_NAME,
   D.ID_PROT ID_REZ_TEST,
   D.BALL,
   D.MINBALL PROHOD_BALL
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_SOTR C,
   V_IN_PR_ATT_KOMM D
where A.ID_PODR = B.ID_PODR and
B.ID_DOLJ = C.ID_DOLJ and C.ID_SOTR = D.ID_SOTR
with read only;





/*==============================================================*/
/* View: V_IN_TRUD_DOG                                          */
/*==============================================================*/
create or replace view V_IN_TRUD_DOG as
select
   A.ID_TRUD_DOG,
   A.ID_SOTR,
   A.OKLAD,
   A.NADB,
   A.PR_VYPL,
   (A.oklad + A.nadb + A.pr_vypl) ZP,
   B.ID_PODR,
   B.PODR_NAME,
   B.ID_DOLJ,
   B.DOLJ_NAME,
   B.SOTR_NAME,
   B.STAJ
from
   T_IN_TRUD_DOG A,
   V_SPR_SOTR B
WHERE A.ID_SOTR = B.ID_SOTR
with read only;

/*==============================================================*/
/* View: V_IN_UCH_SOTR                                          */
/*==============================================================*/
create or replace view V_IN_UCH_SOTR as
select
   A.NAME PODR_NAME,
   A.ID_PODR,
   B.NAME DOLJ_NAME,
   B.ID_DOLJ,
   C.ID_SOTR ID_SOTR,
   C.NAME SOTR_NAME,
   C.DATE_PRIEM,
   C.LAST_ATT_DATE,
   D.OKLAD,
   D.NADB,
   D.PR_VYPL,
   (D.OKLAD +
   D.NADB +
   D.PR_VYPL) ZP
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_SOTR C,
   T_IN_TRUD_DOG D
WHERE A.ID_PODR = B.ID_PODR AND B.ID_DOLJ = C.ID_DOLJ AND C.ID_SOTR = D.ID_SOTR
with read only;

/*==============================================================*/
/* View: V_SPR_VID_RAB                                          */
/*==============================================================*/
create or replace view V_SPR_VID_RAB as
select
   A.ID_PODR ID_PODR,
   A.NAME PODR_NAME,
   B.ID_DOLJ ID_DOLJ,
   B.name DOLJ_NAME,
   C.id_vid_rab ID_VID_RAB,
   C.NAME VID_RAB_NAME,
   C.ED_IZM
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_VID_RAB C
where
    A.ID_PODR = B.ID_PODR and B.ID_DOLJ = C.ID_DOLJ
with read only;

/*==============================================================*/
/* View: V_IN_VED_OB_RAB                                        */
/*==============================================================*/
create or replace view V_IN_VED_OB_RAB as
select
   A.ID_VED_OB_RAB,
   A.ID_VID_RAB,
   A.KOLVO,
   A.START_DATE,
   A.FINISH_DATE,
   B.ID_PODR,
   B.PODR_NAME,
   B.ID_DOLJ,
   B.DOLJ_NAME,
   B.VID_RAB_NAME,
   B.ED_IZM
from
   T_IN_VED_OB_RAB A,
   V_SPR_VID_RAB B
   WHERE A.ID_VID_RAB = B.ID_VID_RAB
with read only;

/*==============================================================*/
/* View: V_IN_VED_ZAT_TR                                        */
/*==============================================================*/
create or replace view V_IN_VED_ZAT_TR as
select
   A.ID_VED_ZAT_TR,
   A.ID_VID_RAB,
   B.ID_PODR,
   B.PODR_NAME,
   B.ID_DOLJ,
   B.DOLJ_NAME,
   B.VID_RAB_NAME,
   B.ED_IZM,
   A.VR_NORM,
   A.CHEL_CH,
   A.CHEL_DN
from
   T_IN_VED_ZAT_TR A,
   V_SPR_VID_RAB B
WHERE A.ID_VID_RAB = B.ID_VID_RAB
with read only;







/*==============================================================*/
/* View: V_OUT_PLAN_ATT                                         */
/*==============================================================*/
create or replace view V_OUT_PLAN_ATT as
select
   A.ID_NORM,
   A.ID_DOLJ,
   A.PERIOD,
   B.PODR_NAME,
   B.DOLJ_NAME,
   B.ID_SOTR,
   B.SOTR_NAME,
   B.DATE_PRIEM,
   B.LAST_ATT_DATE,
   B.OKLAD,
   B.NADB,
   B.PR_VYPL,
   B.ZP,
   ADD_MONTHS(NVL(B.LAST_ATT_DATE, B.DATE_PRIEM), A.PERIOD) PLAN_ATT_DATE
from
   T_SPR_NORM_ATT A,
   V_IN_UCH_SOTR B
where
   A.ID_DOLJ = B.ID_DOLJ

with read only;

/*==============================================================*/
/* View: V_OUT_OTCHET_PLAN_ATT                                  */
/*==============================================================*/
create or replace view V_OUT_OTCHET_PLAN_ATT as
select
   A.PODR_NAME,
   A.DOLJ_NAME,
   A.ID_SOTR,
   A.PLAN_ATT_DATE,
   A.SOTR_NAME,
   B.ID_PROT,
   B.DATE_ATT,
   B.MINBALL,
   B.BALL,
   case case when E.PRIKAZ_TYPE < B.BALL then "Повторная аттестация не нужна" else B.DATE_ATT + 7 POVT_ATT_DATE end 
from
   V_OUT_PLAN_ATT A LEFT OUTER JOIN
   V_IN_PR_ATT_KOMM B ON A.ID_SOTR = B.ID_SOTR
with read only;

/*==============================================================*/
/* View: V_OUT_SHTAT_RASP                                       */
/*==============================================================*/
create or replace view V_OUT_SHTAT_RASP as
select
   A.ID_PODR ID_PODR,
   A.NAME PODR_NAME,
   B.ID_DOLJ ID_DOLJ,
   B.NAME DOLJ_NAME,
   round(MAX(E.KOLVO *F.VR_NORM*7 / ((E.FINISH_DATE-E.START_DATE)*F.CHEL_CH*F.CHEL_DN*F.CHEL_DN)), 0) KOLVO_ED_SOTR,
   round(AVG(G.OKLAD), 2) OKLAD,
   round(AVG(G.NADB), 2) NADB,
   round(AVG(G.PR_VYPL), 2) PR_VYPL,
   round((AVG(G.OKLAD) +AVG(G.NADB) + AVG(G.PR_VYPL))*round(MAX(E.KOLVO *F.VR_NORM*7 / ((E.FINISH_DATE-E.START_DATE)*F.CHEL_CH*F.CHEL_DN*F.CHEL_DN)), 0),0) FOND
from
   T_SPR_PODR A INNER JOIN
   T_SPR_DOLJ B ON A.ID_PODR = B.ID_PODR inner join
   T_SPR_VID_RAB C on B.ID_DOLJ = C.ID_DOLJ inner join
   T_SPR_SOTR D on D.ID_DOLJ = B. ID_DOLJ left outer join
   T_IN_VED_OB_RAB E on E.ID_VID_RAB = C.ID_VID_RAB left outer join
   T_IN_VED_ZAT_TR F ON F.ID_VID_RAB = C.ID_VID_RAB left outer join
   T_IN_TRUD_DOG G ON D.ID_SOTR = G.ID_SOTR
group by A.ID_PODR , A.NAME , B.ID_DOLJ , B.NAME 
with read only;


/*==============================================================*/
/* View: V_OUT_VED_DV_KADR                                      */
/*==============================================================*/
create or replace view V_OUT_VED_DV_KADR as
select
   A.YEAR,
   B.NAME PODR_NAME,
   C.NAME DOLJ_NAME,
   SUM(case when E.PRIKAZ_TYPE=0 then 1 else 0 end) KOL_NAIM,
   SUM(case when E.PRIKAZ_TYPE=1 then 1 else 0 end) KOL_PEREV,
   SUM(case when E.PRIKAZ_TYPE=2 then 1 else 0 end) KOL_UVOL
from
   T_YEARS A,
   T_SPR_PODR B,
   T_SPR_DOLJ C,
   T_SPR_SOTR D,
   T_IN_PRIKAZ E
   
WHERE A.YEAR = extract(year from E.DATE_PR) AND B.ID_PODR = C.ID_PODR AND C.ID_DOLJ = D.ID_DOLJ AND D.ID_SOTR = E.ID_SOTR 
GROUP BY  A.YEAR,B.NAME ,C.NAME 
with read only;

/*==============================================================*/
/* View: V_OUT_VED_POTR_KADR                                    */
/*==============================================================*/
create or replace view V_OUT_VED_POTR_KADR as
select
   B.ID_PODR,
   B.PODR_NAME,
   B.ID_DOLJ ID_DOLJ,
   B.DOLJ_NAME,
   B.KOLVO_ED_SOTR PLAN_KOLVO,
   (Select count(ID_DOLJ) from T_SPR_SOTR where ID_DOLJ= B.ID_DOLJ)  UCH_KOLVO ,
   B.KOLVO_ED_SOTR-(Select count(ID_DOLJ) from T_SPR_SOTR where ID_DOLJ= B.ID_DOLJ) TR_KOLVO 
from
   T_SPR_SOTR A,
   V_OUT_SHTAT_RASP B,
   V_IN_VED_ZAT_TR F,
   T_IN_VED_OB_RAB E
where
   B.ID_DOLJ = A.ID_DOLJ
group by
   B.ID_PODR,
   B.PODR_NAME,
   B.ID_DOLJ,
   B.DOLJ_NAME,
   B.KOLVO_ED_SOTR

with read only;


/*==============================================================*/
/* View: V_SPR_DOLJ                                             */
/*==============================================================*/
create or replace view V_SPR_DOLJ as
select
   A.ID_PODR ID_PODR,
   A.NAME PODR_NAME,
   B.ID_DOLJ,
   B.NAME DOLJ_NAME
from
   T_SPR_PODR A,
   T_SPR_DOLJ B
   where A.ID_PODR = B.ID_PODR
with read only;

/*==============================================================*/
/* View: V_SPR_NORM_ATT                                         */
/*==============================================================*/
create or replace view V_SPR_NORM_ATT as
select
   A.ID_PODR,
   A.NAME PODR_NAME,
   B.ID_DOLJ,
   B.NAME DOLJ_NAME,
   C.ID_NORM,
   C.PERIOD
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_NORM_ATT C
   
 WHERE A.ID_PODR = B.ID_PODR AND B.ID_DOLJ = C.ID_DOLJ
with read only;


/*==============================================================*/
/* View: V_SPR_ORG                                              */
/*==============================================================*/
create or replace view V_SPR_ORG as
select
   A.ID_THEME,
   A.NAME THEME_NAME,
   B.ID_ORG,
   B.NAME ORG_NAME,
   B.DATE_PROV,
   B.COST
from
   T_SPR_THEME A,
   T_SPR_ORG B
WHERE A.ID_THEME = B.ID_THEME
with read only;

/*==============================================================*/
/* View: V_SPR_PODR                                             */
/*==============================================================*/
create or replace view V_SPR_PODR as
select
   T_SPR_PODR.ID_PODR,
   T_SPR_PODR.NAME
from
   T_SPR_PODR
with read only;


/*==============================================================*/
/* View: V_OUT_AN_TEK                                      */
/*==============================================================*/

create or replace view V_OUT_AN_TEK as
select
   A.NAME PODR_NAME,
   B.NAME DOLJ_NAME,
   D.PRICHINA,
   ROUND(100*(SELECT COUNT(ID_PRIKAZ) FROM T_IN_PRIKAZ where PRIKAZ_TYPE = 2 AND PRICHINA=D.PRICHINA)/(SELECT COUNT(ID_PRIKAZ) FROM T_IN_PRIKAZ where PRIKAZ_TYPE = 2)) KOLVO
from
   T_SPR_PODR A,
   T_SPR_DOLJ B,
   T_SPR_SOTR C,
   T_IN_PRIKAZ D
where
    A.ID_PODR = B.ID_PODR AND
 B.ID_DOLJ = C.ID_DOLJ AND
 C.ID_SOTR = D.ID_SOTR AND D.PRIKAZ_TYPE = 2
group by PRICHINA,A.NAME,B.NAME 
order by 3



/*==============================================================*/
/* View: V_IN_SVID_POV_KV                                       */
/*==============================================================*/
create or replace view V_IN_SVID_POV_KV as
select
   A.ID_SVID,
   A.ID_PRIKAZ,
   A.FACT_DATE,
   A.DOC_NAME,
   B.ID_ORG,
   B.ID_ZAYAV,
   B.ID_THEME,
   B.THEME_NAME,
   B.SRO,
   B.ID_PODR,
   B.PODR_NAME,
   B.ID_DOLJ,
   B.DOLJ_NAME,
   B.ID_SOTR,
   B.SOTR_NAME,
   C.ORG_NAME,
   C.DATE_PROV
from
   T_IN_SVID_POV_KV A,
   V_IN_PRIKAZ_POV_KV B,
   V_OUT_GRAF_POV_KV C
   WHERE A.ID_PRIKAZ = B.ID_PRIKAZ and C.ID_PRIKAZ = B.ID_PRIKAZ
with read only;

/*==============================================================*/
/* View: V_OUT_CONTROL_GRAF_POV_KV                              */
/*==============================================================*/
create or replace view V_OUT_CONTROL_GRAF_POV_KV as
select
   A.ID_PRIKAZ,
   A.ID_THEME,
   A.THEME_NAME,
   A.ID_ZAYAV,
   A.SRO,
   A.ID_PODR,
   A.PODR_NAME,
   A.ID_DOLJ,
   A.DOLJ_NAME,
   A.ID_SOTR,
   A.SOTR_NAME,
   A.ID_ORG,
   A.ORG_NAME,
   A.DATE_PROV,
   A.COST,
   B.ID_SVID,
   B.FACT_DATE,
   B.DOC_NAME
from
   V_OUT_GRAF_POV_KV A LEFT OUTER JOIN
   V_IN_SVID_POV_KV B ON A.ID_PRIKAZ = B.ID_PRIKAZ AND A.ID_ZAYAV = B.ID_ZAYAV
with read only;

alter table T_IN_PRIKAZ
   add constraint FK_T_IN_PRI_REFERENCE_T_SPR_SO foreign key (ID_SOTR)
      references T_SPR_SOTR (ID_SOTR);

alter table T_IN_PRIKAZ
   add constraint FK_T_IN_PRI_REFERENCE_T_SPR_PO foreign key (ID_PODR)
      references T_SPR_PODR (ID_PODR);

alter table T_IN_PRIKAZ_POV_KV
   add constraint FK_T_IN_PRI_REFERENCE_T_SPR_OR foreign key (ID_ORG)
      references T_SPR_ORG (ID_ORG);

alter table T_IN_PRIKAZ_POV_KV
   add constraint FK_T_IN_PRI_REFERENCE_T_IN_ZAY foreign key (ID_ZAYAV)
      references T_IN_ZAYAV_POV_KV (ID_ZAYAV);

alter table T_IN_PR_ATT_KOMM
   add constraint FK_T_IN_PR__REFERENCE_T_SPR_SO foreign key (ID_SOTR)
      references T_SPR_SOTR (ID_SOTR);

alter table T_IN_REZ_TEST
   add constraint FK_T_IN_REZ_REFERENCE_T_SPR_SO foreign key (ID_SOTR)
      references T_SPR_SOTR (ID_SOTR);

alter table T_IN_SVID_POV_KV
   add constraint FK_T_IN_SVI_REFERENCE_T_IN_PRI foreign key (ID_PRIKAZ)
      references T_IN_PRIKAZ_POV_KV (ID_PRIKAZ);

alter table T_IN_TRUD_DOG
   add constraint FK_T_IN_TRU_REFERENCE_T_SPR_SO foreign key (ID_SOTR)
      references T_SPR_SOTR (ID_SOTR)
      on delete cascade;

alter table T_IN_VED_OB_RAB
   add constraint FK_T_IN_V_O_R_REF_T_S_V_R foreign key (ID_VID_RAB)
      references T_SPR_VID_RAB (ID_VID_RAB)
      on delete cascade;

alter table T_IN_VED_ZAT_TR
   add constraint FK_T_I_V_Z_T_REF_T_S_V_R foreign key (ID_VID_RAB)
      references T_SPR_VID_RAB (ID_VID_RAB)
      on delete cascade;

alter table T_IN_ZAYAV_POV_KV
   add constraint FK_T_IN_ZAY_REFERENCE_T_SPR_TH foreign key (ID_THEME)
      references T_SPR_THEME (ID_THEME);

alter table T_IN_ZAYAV_POV_KV
   add constraint FK_T_IN_ZAY_REFERENCE_T_SPR_SO foreign key (ID_SOTR)
      references T_SPR_SOTR (ID_SOTR);

alter table T_SPR_DOLJ
   add constraint FK_T_SPR_DO_REFERENCE_T_SPR_PO foreign key (ID_PODR)
      references T_SPR_PODR (ID_PODR)
      on delete cascade;

alter table T_SPR_NORM_ATT
   add constraint FK_T_SPR_NO_REFERENCE_T_SPR_DO foreign key (ID_DOLJ)
      references T_SPR_DOLJ (ID_DOLJ);

alter table T_SPR_OB_DEN_SR
   add constraint FK_T_SPR_OB_REFERENCE_T_YEARS foreign key (YEAR)
      references T_YEARS (YEAR);

alter table T_SPR_ORG
   add constraint FK_T_SPR_OR_REFERENCE_T_SPR_TH foreign key (ID_THEME)
      references T_SPR_THEME (ID_THEME);

alter table T_SPR_SOTR
   add constraint FK_T_SPR_SO_REFERENCE_T_SPR_DO foreign key (ID_DOLJ)
      references T_SPR_DOLJ (ID_DOLJ)
      on delete cascade;

alter table T_SPR_VID_RAB
   add constraint FK_T_SPR_VI_REFERENCE_T_SPR_DO foreign key (ID_DOLJ)
      references T_SPR_DOLJ (ID_DOLJ);

create trigger "tib_t_in_prikaz" before insert
on T_IN_PRIKAZ for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_PRIKAZ" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_PRIKAZ from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_in_prikaz_pov_kv" before insert
on T_IN_PRIKAZ_POV_KV for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_PRIKAZ" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_PRIKAZ from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_in_pr_att_komm" before insert
on T_IN_PR_ATT_KOMM for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_PROT" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_PROT from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_in_rez_test" before insert
on T_IN_REZ_TEST for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_REZ_TEST" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_REZ_TEST from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_in_svid_pov_kv" before insert
on T_IN_SVID_POV_KV for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_SVID" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_SVID from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_in_trud_dog" before insert
on T_IN_TRUD_DOG for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_TRUD_DOG" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_TRUD_DOG from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_in_ved_ob_rab" before insert
on T_IN_VED_OB_RAB for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_VED_OB_RAB" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_VED_OB_RAB from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_in_ved_zat_tr" before insert
on T_IN_VED_ZAT_TR for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_VED_ZAT_TR" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_VED_ZAT_TR from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_in_zayav_pov_kv" before insert
on T_IN_ZAYAV_POV_KV for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_ZAYAV" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_ZAYAV from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_spr_dolj" before insert
on T_SPR_DOLJ for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_DOLJ" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_DOLJ from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_spr_norm_att" before insert
on T_SPR_NORM_ATT for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_NORM" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_NORM from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_spr_org" before insert
on T_SPR_ORG for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_ORG" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_ORG from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_spr_podr" before insert
on T_SPR_PODR for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_PODR" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_PODR from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_spr_sotr" before insert
on T_SPR_SOTR for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_SOTR" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_SOTR from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_spr_theme" before insert
on T_SPR_THEME for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_THEME" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_THEME from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger "tib_t_spr_vid_rab" before insert
on T_SPR_VID_RAB for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    --  Column "ID_VID_RAB" uses sequence IDENTSEQUENCE
    select IDENTSEQUENCE.NEXTVAL INTO :new.ID_VID_RAB from dual;

--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/

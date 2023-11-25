use finalproject

create table Posisi
(
    IDPosisi varchar (5) not null primary key,
    NamaPosisi varchar (50) not null,
    GajiTetap int not null
);

create table Cabang
(
    IDCabang varchar (6) not null primary key,
    NamaCabang varchar (50) not null
);

create table Pegawai
(
    IDPegawai varchar (5) not null primary key,
    NamaPegawai varchar (50) not null,
    AlamatPegawai varchar (100) not null,
    EmailPegawai varchar (100) not null,
    TglLahirPegawai date not null,
    Password varchar (10) not null,
    Telepon char (24) not null,
    IDPosisi varchar (5) REFERENCES Posisi,
    IDCabang varchar (6) references Cabang
);

create table Absen
(
    IDPegawai varchar (5) REFERENCES Pegawai,
    IDAbsen varchar (30) primary key not null,
    JamMasuk time not null,
    JamPulang time not null,
    Lembur int not null,
    Status varchar (15) not null
);

INSERT INTO Posisi
VALUES
    ('P0001', 'Boss', 20000000);
INSERT INTO Posisi
VALUES
    ('P0002', 'Manajer', 15000000);
insert INTO Posisi
VALUES
    ('P0003', 'Karyawan', 10000000);

INSERT INTO Cabang
VALUES ('JKT001', 'Jakarta Barat')
INSERT INTO Cabang
VALUES ('BDG002', 'Bandung')

-- Boss
INSERT INTO Pegawai
VALUES
    ('BOS01', 'Bos', 'alamat', 'bos@bos.bos', '1980-02-20', 'AkunBos', '34745736', 'P0001', 'JKT001')



select * from Cabang
select * from Pegawai
select * from Posisi
select * from Absen
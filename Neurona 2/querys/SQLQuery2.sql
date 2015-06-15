select * from caracters
where CARACTER collate Latin1_General_CS_AS = 'a'

select * from caracters
where CARACTER = 'a'


delete from caracters
where ID = 49

update caracters
set IN_CARACTER = '',
    OUT_CARACTER = ''
where CARACTER collate Latin1_General_CS_AS = 'a'
--on master
create login //loginname// with password = '//password//'

--on heartyhearthDB
create user user_//loginname// from login //loginname//

alter role db_datareader add member user_//loginname//
alter role db_datawriter add member user_//loginname//
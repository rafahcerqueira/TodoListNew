SELECT * FROM Usuarios 

--SELECT * FROM Usuarios WHERE Email = 'rafa@gmail.com'

--ALTER TABLE Todo
--ADD Data DATETIME;

SELECT * FROM Todo

-- Excluir tarefas do usuário
DELETE FROM Todo
WHERE ID = 'ab0736f8-1327-48df-9c7f-80c30c43bd59';

-- Excluir o usuário
DELETE FROM Usuarios
WHERE ID = '';

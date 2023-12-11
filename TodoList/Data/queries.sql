SELECT * FROM Usuarios 

--SELECT * FROM Usuarios WHERE Email = 'rafa@gmail.com'

--ALTER TABLE Todo
--ADD Data DATETIME;

SELECT * FROM Todo

-- Excluir tarefas do usuário
DELETE FROM Todo
WHERE UserID = '';

-- Excluir o usuário
DELETE FROM Usuarios
WHERE ID = '';

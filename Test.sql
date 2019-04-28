USE zhengrui;

SELECT *
FROM Crusader.[User] u
ORDER BY u.UserId ASC;

SELECT *
FROM Crusader.NPC n
WHERE
n.NPCName LIKE '%Remi%' AND
n.Skill LIKE '%W%'
ORDER BY n.NPCId ASC;
USE zhengrui;

SELECT *
FROM Crusader.[User] u
ORDER BY u.UserId ASC;

SELECT DISTINCT n.Faction
FROM Crusader.NPC n
WHERE
n.NPCName LIKE '%Remi%' AND
n.Skill LIKE '%W%'
ORDER BY n.NPCId ASC;

SELECT *
FROM Crusader.Hero h
INNER JOIN Crusader.NPC n ON n.NPCName = h.SoulboundWeapon;

SELECT DISTINCT h.Faction
FROM Crusader.Hero h;
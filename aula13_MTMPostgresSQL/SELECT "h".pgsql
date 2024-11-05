SELECT "h"."Nome" 
FROM "Habilidades" AS "h"
JOIN "PessoaHabilidade" AS "ph" ON "h"."HabilidadeId" = "ph"."HabilidadeId"
WHERE "ph"."PessoaId" = 1;
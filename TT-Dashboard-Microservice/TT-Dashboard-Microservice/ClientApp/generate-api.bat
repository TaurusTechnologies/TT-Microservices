curl https://localhost:44381/swagger/v1/swagger.json > swagger.json
npx swagger-typescript-api -p ./swagger.json -o ./src/apiClient --modular
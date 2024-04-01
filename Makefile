.PHONY: build clean infra run unit-tests integration-tests create-db network

default-network := twistag-network 

network:
	@docker network ls | grep ${default-network} > /dev/null || docker network create --driver bridge ${default-network}

infra: network
	@docker-compose up -d sql_server
	@docker-compose up -d --build

run: infra
	@docker-compose up -d app



clean:
	@docker-compose -f docker-compose.yaml down

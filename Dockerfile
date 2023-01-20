ARG PROJECT_NAME=Marketplace
ARG CONFIGURATION=Release

FROM mcr.microsoft.com/dotnet/sdk:7.0.101-alpine3.17 as build

ARG PROJECT_NAME
ARG CONFIGURATION

WORKDIR /${PROJECT_NAME}

COPY ./ ./

WORKDIR /${PROJECT_NAME}/src/${PROJECT_NAME}.Api

RUN dotnet restore
RUN dotnet publish -c ${CONFIGURATION} --self-contained --use-current-runtime -o ./publish

FROM mcr.microsoft.com/dotnet/runtime-deps:7.0-alpine3.17 as run

ARG PROJECT_NAME

ENV EXECUTABLE_NAME=${PROJECT_NAME}

EXPOSE 80

WORKDIR /${PROJECT_NAME}

COPY --from=build /${PROJECT_NAME}/src/${PROJECT_NAME}.Api/publish ./

ENTRYPOINT ./${EXECUTABLE_NAME}.Api

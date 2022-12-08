import { CreateTag } from "./helpers";

export const K6Options = (host, path, payload, requestType) => ({
  tags: {
    name: CreateTag(host, path, payload, requestType),
  },
  vus: 1,
  iterations: 200,
});

export const GrpcClientParams = {
  plaintext: true,
  maxReceiveSize: 1000 * 1024 * 1024,
  maxSendSize: 1000 * 1024 * 1024,
};

export const RestfulClientParams = {
  headers: {
    'Content-Type': 'application/json',
  },
};
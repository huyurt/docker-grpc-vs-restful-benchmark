import http from 'k6/http';
import { K6Options, RestfulClientParams } from '../utils/options';
import { Consts, Enums } from '../utils/consts';

const host = process.env.RESTFUL_HOST;
const path = Consts.Path.Restful.Data.GetFile;
const payload = {
  Index: __ENV.INDEX,
};

export let options = K6Options(host, path, payload, Enums.RequestType.Restful);

export default function () {
  const response = http.post(host + path, JSON.stringify(payload), RestfulClientParams);
  //check(response, {
  //  "status is 200": (r) => r.status === 200,
  //});
};

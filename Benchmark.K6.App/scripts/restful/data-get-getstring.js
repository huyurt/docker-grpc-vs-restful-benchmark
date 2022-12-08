import http from 'k6/http';
import { K6Options, RestfulClientParams } from '../utils/options';
import { Consts, Enums } from '../utils/consts';

const host = process.env.RESTFUL_HOST;
const path = Consts.Path.Restful.Data.GetGetString;
const params = '?Index=' + __ENV.INDEX;

export let options = K6Options(host, path, params, Enums.RequestType.Restful);

export default function () {
  const response = http.get(host + path + params, RestfulClientParams);
  //check(response, {
  //  "status is 200": (r) => r.status === 200,
  //});
};

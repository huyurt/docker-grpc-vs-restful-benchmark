import grpc from 'k6/net/grpc';
import { K6Options, GrpcClientParams } from '../utils/options';
import { Consts, Enums } from '../utils/consts';

const host = process.env.GRPC_HOST;
const path = Consts.Path.Grpc.Data.GetUserModelByFilterStream;
const data = {
  Id: __ENV.ID,
  ReferenceKey: __ENV.REFERENCEKEY,
  Name: __ENV.NAME,
  Surname: __ENV.SURNAME,
  Email: __ENV.EMAIL,
};

const client = new grpc.Client();
client.load([Consts.ProtoFolder], Consts.ProtoFiles.Data);

export let options = K6Options(host, path, data, Enums.RequestType.GrpcStream);

export default () => {
  client.connect(host, GrpcClientParams);

  const response = client.invoke(path, data);
  //check(response, {
  //  'status is OK': (r) => r && r.status === grpc.StatusOK,
  //});
  
  client.close();
};
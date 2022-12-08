const dataServicePath = 'data';
const dataService = 'DataService';
const repeatedDataServicePath = 'repeateddata';
const repeatedDataService = 'RepeatedDataService';
const getGetStringEndpoint = 'GetGetString';
const getStringEndpoint = 'GetString';
const getStringStreamEndpoint = 'GetStringStream';
const getStringArrayEndpoint = 'GetStringArray';
const getStringArrayStreamEndpoint = 'GetStringArrayStream';
const getIntArrayEndpoint = 'GetIntArray';
const getIntArrayStreamEndpoint = 'GetIntArrayStream';
const getFileEndpoint = 'GetFile';
const getFileStreamEndpoint = 'GetFileStream';
const getGetUserModelEndpoint = 'GetGetUserModel';
const getUserModelEndpoint = 'GetUserModel';
const getUserModelByFilterEndpoint = 'GetUserModelByFilter';
const getUserModelStreamEndpoint = 'GetUserModelStream';
const getUserModelByFilterStreamEndpoint = 'GetUserModelByFilterStream';

const Consts = {
  Path: {
    Grpc: {
      Data: {
        GetString: `${dataServicePath}.${dataService}/${getStringEndpoint}`,
        GetStringStream: `${dataServicePath}.${dataService}/${getStringStreamEndpoint}`,
        GetIntArray: `${dataServicePath}.${dataService}/${getIntArrayEndpoint}`,
        GetIntArrayStream: `${dataServicePath}.${dataService}/${getIntArrayStreamEndpoint}`,
        GetFile: `${dataServicePath}.${dataService}/${getFileEndpoint}`,
        GetFileStream: `${dataServicePath}.${dataService}/${getFileStreamEndpoint}`,
        GetUserModel: `${dataServicePath}.${dataService}/${getUserModelEndpoint}`,
        GetUserModelByFilter: `${dataServicePath}.${dataService}/${getUserModelByFilterEndpoint}`,
        GetUserModelStream: `${dataServicePath}.${dataService}/${getUserModelStreamEndpoint}`,
        GetUserModelByFilterStream: `${dataServicePath}.${dataService}/${getUserModelByFilterStreamEndpoint}`,
      },
      RepeatedData: {
        GetString: `${repeatedDataServicePath}.${repeatedDataService}/${getStringEndpoint}`,
        GetStringStream: `${repeatedDataServicePath}.${repeatedDataService}/${getStringStreamEndpoint}`,
        GetStringArray: `${repeatedDataServicePath}.${repeatedDataService}/${getStringArrayEndpoint}`,
        GetStringArrayStream: `${repeatedDataServicePath}.${repeatedDataService}/${getStringArrayStreamEndpoint}`,
      },
    },
    Restful: {
      Data: {
        GetGetString: `${dataServicePath}/${getGetStringEndpoint}`,
        GetString: `${dataServicePath}/${getStringEndpoint}`,
        GetIntArray: `${dataServicePath}/${getIntArrayEndpoint}`,
        GetFile: `${dataServicePath}/${getFileEndpoint}`,
        GetGetUserModel: `${dataServicePath}/${getGetUserModelEndpoint}`,
        GetUserModel: `${dataServicePath}/${getUserModelEndpoint}`,
        GetUserModelByFilter: `${dataServicePath}/${getUserModelByFilterEndpoint}`,
      },
      RepeatedData: {
        GetString: `${repeatedDataServicePath}/${getStringEndpoint}`,
        GetStringArray: `${repeatedDataServicePath}/${getStringArrayEndpoint}`,
      },
    },
  },
  ProtoFolder: 'protos',
  ProtoFiles: {
    Data: `${dataServicePath}.proto`,
    RepeatedData: `${repeatedDataServicePath}.proto`,
  },
};

const Enums = {
  RequestType: {
    Restful: 1,
    Grpc: 2,
    GrpcStream: 3,
  },
};

export { Consts, Enums };
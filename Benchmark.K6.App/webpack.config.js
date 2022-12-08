const path = require('path');
const Dotenv = require('dotenv-webpack');
const CopyWebpackPlugin = require('copy-webpack-plugin');

const restfulScriptPath = './scripts/restful/';
const grpcScriptPath = './scripts/grpc/';
const dataServicePath = 'data';
const repeatedDataServicePath = 'repeateddata';

module.exports = {
  entry: {
    restful_data_get_getstring: `${restfulScriptPath}${dataServicePath}-get-getstring.js`,
    restful_data_getstring: `${restfulScriptPath}${dataServicePath}-getstring.js`,
    restful_data_getintarray: `${restfulScriptPath}${dataServicePath}-getintarray.js`,
    restful_data_getfile: `${restfulScriptPath}${dataServicePath}-getfile.js`,
    restful_data_get_getusermodel: `${restfulScriptPath}${dataServicePath}-get-getusermodel.js`,
    restful_data_getusermodel: `${restfulScriptPath}${dataServicePath}-getusermodel.js`,
    restful_data_getusermodelbyfilter: `${restfulScriptPath}${dataServicePath}-getusermodelbyfilter.js`,
    restful_repeateddata_getstring: `${restfulScriptPath}${repeatedDataServicePath}-getstring.js`,
    restful_repeateddata_getstringarray: `${restfulScriptPath}${repeatedDataServicePath}-getstringarray.js`,
    
    grpc_data_getstring: `${grpcScriptPath}${dataServicePath}-getstring.js`,
    grpc_data_getstringstream: `${grpcScriptPath}${dataServicePath}-getstringstream.js`,
    grpc_data_getintarray: `${grpcScriptPath}${dataServicePath}-getintarray.js`,
    grpc_data_getintarraystream: `${grpcScriptPath}${dataServicePath}-getintarraystream.js`,
    grpc_data_getfile: `${grpcScriptPath}${dataServicePath}-getfile.js`,
    grpc_data_getfilestream: `${grpcScriptPath}${dataServicePath}-getfilestream.js`,
    grpc_data_getusermodel: `${grpcScriptPath}${dataServicePath}-getusermodel.js`,
    grpc_data_getusermodelbyfilter: `${grpcScriptPath}${dataServicePath}-getusermodelbyfilter.js`,
    grpc_data_getusermodelstream: `${grpcScriptPath}${dataServicePath}-getusermodelstream.js`,
    grpc_data_getusermodelbyfilterstream: `${grpcScriptPath}${dataServicePath}-getusermodelbyfilterstream.js`,
    grpc_repeateddata_getstring: `${grpcScriptPath}${repeatedDataServicePath}-getstring.js`,
    grpc_repeateddata_getstringstream: `${grpcScriptPath}${repeatedDataServicePath}-getstringstream.js`,
    grpc_repeateddata_getstringarray: `${grpcScriptPath}${repeatedDataServicePath}-getstringarray.js`,
    grpc_repeateddata_getstringarraystream: `${grpcScriptPath}${repeatedDataServicePath}-getstringarraystream.js`,
  },
  output: {
    path: path.resolve(__dirname, 'dist'),
    libraryTarget: 'commonjs',
    filename: '[name].js',
  },
  module: {
    rules: [
      {
        test: /\.js$/,
        exclude: /node_modules/,
        use: 'babel-loader'
      },
    ]
  },
  target: 'web',
  externals: /k6(\/.*)?/,
  plugins: [
    new Dotenv(),
    new CopyWebpackPlugin(
      {
        patterns: [
          {
            from: '../Benchmark.Shared/Protos',
            to: 'protos'
          },
        ],
      }
    ),
  ],
  optimization: {
    minimize: false,
  },
};
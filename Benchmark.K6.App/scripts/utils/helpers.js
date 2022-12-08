const CreateTag = (host, path, payload, requestType) => {
  return host + path + '?ReqType=' + requestType + '&Date=' + new Date().toISOString() + '&Params=' + JSON.stringify(payload);
};

export { CreateTag };
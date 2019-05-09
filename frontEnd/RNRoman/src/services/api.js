import axios from "axios";

const api = axios.create({
  baseURL: "https://romanapp.azurewebsites.net/api"
});

export default api;
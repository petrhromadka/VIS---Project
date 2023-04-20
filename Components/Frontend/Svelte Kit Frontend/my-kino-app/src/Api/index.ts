import axios from "axios";

const API_URL = "https://example.com/api"; // upravte na URL vašeho backendu

export async function getMovies() {
  const response = await axios.get(`${API_URL}/movies`);
  return response.data;
}

export async function makeReservation(reservationData: any) {
  const response = await axios.post(`${API_URL}/reservations`, reservationData);
  return response.data;
}

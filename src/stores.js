import { writable } from "svelte/store";

export const totalPrice = writable(0);
export const selectedEvent = writable(null);
export const selectedSeats = writable(new Array(0));
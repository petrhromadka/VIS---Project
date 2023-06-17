<script>
	import { totalPrice, selectedEvent, selectedSeats } from '../../../stores.js';

	import Badges from '../../../components/Badges.svelte';
	import EventTable from '../../../components/detail/EventTable.svelte';
	import Thumbnail from '../../../components/detail/Thumbnail.svelte';
	import SeatSelect from '../../../components/detail/SeatSelect.svelte';
	import { onDestroy } from 'svelte';

	let totalPriceStoreValue; 
	let selectedEventStoreValue;
	let selectedSeatsStoreValue;

	let customerEmail = "";
	let customerPhone = "";
	let customerName = "";

	let proceedToCart = false;

	const totalPriceUnsubscribe = totalPrice.subscribe(value => {
		totalPriceStoreValue = value;
	});

	const selectEventUnsubscribe = selectedEvent.subscribe(value => {
		selectedEventStoreValue = value;
	})

	const selectedSeatsUnsubscribe = selectedSeats.subscribe(value => {
		selectedSeatsStoreValue = value;
		updateTotalPrice();
	})

	function updateTotalPrice(){
		if(selectedEventStoreValue == null) return;
		totalPrice.update(tp => {
			tp = selectedEventStoreValue.price * selectedSeatsStoreValue.length;
			return tp;
		});
	}

	function returnToSeatSelect(){
		proceedToCart = false;

		customerEmail = "";
		customerPhone = "";
		customerName = "";

		selectedSeats.update(s => {
			s = new Array(0);
			return s;
		})
	}

	function clearStoredProps() {
		selectedEvent.set(null);
		selectedSeats.set(new Array());
		totalPrice.set(0);

		proceedToCart = false;
	}


	function sendReservation(){

		if(!customerName || !customerPhone){
			alert("Zadejte povinné údaje!");
			return;
		}

		fetch("https://localhost:3333/api/reservation/create", {
			method: "POST",
			body: JSON.stringify({
				EventId: selectedEventStoreValue.id,
				CustomerName: customerName,
				CustomerEmail: customerEmail,
				customerPhone: customerPhone,
				TotalPrice: totalPriceStoreValue,
				Seats: selectedSeatsStoreValue
			}),
			headers: {
    			"Content-type": "application/json; charset=UTF-8"
  			}
		})
		.finally(() => {
			alert("Vstupenky rezervovány!");
			window.location.href = "/";
		})
	}

	function getDateOfEvent(inputDate) {
		const date = new Date(inputDate);

		const day = date.getDate();
		const month = date.getMonth() + 1;
		const dayName = getDayName(date.getDay());

		const formattedDate = `${day}.${month} (${dayName})`;
		return formattedDate;
	}

	function getDayName(dayNumber) {
		const dayNames = ['Neděle', 'Pondělí', 'Úterý', 'Středa', 'Čtvrtek', 'Pátek', 'Sobota'];
		return dayNames[dayNumber];
	}

	function getTimeOfEvent(inputDate) {
		const date = new Date(inputDate);

		const hour = date.getHours();
		const minutes = date.getMinutes();

		const formattedTime = `${hour}:${minutes}`;
		return formattedTime;
	}


	export let data;

	onDestroy(() => {
		totalPriceUnsubscribe();
		selectEventUnsubscribe();
		selectedSeatsUnsubscribe();

		clearStoredProps();
	})
</script>

<div class="bg-white py-8 sm:py-16">
	<div class="mx-auto max-w-7xl px-6 lg:px-8">
		<div
			class="mx-auto grid max-w-2xl grid-cols-1 items-start gap-x-8 gap-y-16 sm:gap-y-24 lg:mx-0 lg:max-w-none lg:grid-cols-2"
		>
			<Thumbnail thumbnailUrl={data.thumbnail} />
			<div>
				<div class="text-base leading-7 text-gray-700 lg:max-w-lg">
					<h1 class="mt-2 text-3xl font-bold tracking-tight text-gray-900 sm:text-4xl">
						{data.title}
					</h1>
					<p class="my-2 text-gray-400">Režie: {data.director} • {data.duration} min.</p>
					<Badges rating={data.rating} genre={data.genre} />
					<div class="max-w-xl">
						<p class="mt-6">{data.description}</p>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>

<div class="relative">
	<div class="absolute inset-0 flex items-center" aria-hidden="true">
		<div class="w-full border-t border-gray-300" />
	</div>
	<div class="relative flex justify-center" />
</div>

<div class="px-4 sm:px-6 lg:px-8 py-8 lg:py-16">
	{#if !proceedToCart}
		{#if selectedEventStoreValue == null}
			<div class="sm:flex sm:items-center">
				<div class="sm:flex-auto">
					<h1 class="text-base font-semibold leading-6 text-gray-900">Seznam promítání</h1>
					<p class="mt-2 text-sm text-gray-700">Vyberte termín promítaní filmu.</p>
				</div>
			</div>
			<div class="-mx-4 mt-10 ring-1 ring-gray-300 sm:mx-0 sm:rounded-lg">
				<EventTable events={data.events} />
			</div>
		{:else}
			<div class="sm:flex sm:items-center">
				<div class="sm:flex-auto">
					<h1 class="text-base font-semibold leading-6 text-gray-900">Rezervace sedadel</h1>
					<p class="mt-2 text-sm text-gray-700">
						{getDateOfEvent(selectedEventStoreValue.dateTime)} - {getTimeOfEvent(selectedEventStoreValue.dateTime)} - {selectedEventStoreValue.hall.name}
					</p>
				</div>
				<div class="mt-3 flex sm:ml-4 sm:mt-0">
					<p class="mr-4 flex items-center justify-center">Celková cena: {totalPriceStoreValue} kč</p>
					<button
						type="button"
						on:click={() => clearStoredProps()}
						class="inline-flex items-center rounded-md bg-white px-3 py-2 text-sm font-semibold text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 hover:bg-gray-50"
						>Zpět</button
					>
					<button
						type="button"
						on:click={() => {
							if(!selectedSeatsStoreValue.length == 0){
								proceedToCart = true;
							}
						}}
						class="ml-3 inline-flex items-center rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600"
						>Hotovo</button
					>
				</div>
			</div>
			<SeatSelect selectedEvent={selectedEventStoreValue}/>
		{/if}
	{:else}
		<div class="sm:flex sm:items-center">
			<div class="sm:flex-auto">
				<h1 class="text-base font-semibold leading-6 text-gray-900">Platba rezervace</h1>
				<p class="mt-2 text-sm text-gray-700">
					{getDateOfEvent(selectedEventStoreValue.dateTime)} - {getTimeOfEvent(selectedEventStoreValue.dateTime)} - {selectedEventStoreValue.hall.name}
				</p>
			</div>
			<div class="mt-3 flex sm:ml-4 sm:mt-0">
				<button
					type="button"
					on:click={returnToSeatSelect}
					class="inline-flex items-center rounded-md bg-white px-3 py-2 text-sm font-semibold text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 hover:bg-gray-50"
					>Zpět</button
				>
			</div>
		</div>

		<div class="flex flex-col md:flex-row gap-8 mt-16">
			<div class="md:w-1/2">
				<div class="mb-4">
					<label for="customerName" class="text-base text-gray-600 dark:text-gray-300"
						>Vaše jméno a příjmení*:</label
					>
					<input
						type="text"
						id="customerName"
						required
						class="mt-1 p-2 w-full border rounded-md text-gray-900 dark:text-white dark:bg-gray-700"
						bind:value={customerName}
					/>
				</div>
				<div class="mb-4">
					<label for="phoneNumber" class="text-base text-gray-600 dark:text-gray-300"
						>Zadejte Vaše telefonní číslo:</label
					>
					<input
						type="tel"
						id="phoneNumber"
						required
						class="mt-1 p-2 w-full border rounded-md text-gray-900 dark:text-white dark:bg-gray-700"
						bind:value={customerPhone}
					/>
				</div>
				<div class="mb-4">
					<label for="email" class="text-base text-gray-600 dark:text-gray-300"
						>Zadejte svůj email*:</label
					>
					<input
						type="email"
						id="email"
						class="mt-1 p-2 w-full border rounded-md text-gray-900 dark:text-white dark:bg-gray-700"
						bind:value={customerEmail}
					/>
				</div>
			</div>

			<div class="md:w-1/2">
				<div class="bg-gray-200 dark:bg-gray-700 p-4 rounded-md">
					<p class="text-base font-bold mb-2 text-gray-900 dark:text-white">Film:</p>
					<p class="text-lg text-gray-700 dark:text-white mb-4">{data.title} - {totalPriceStoreValue} Kč</p>
					<p class="text-base font-bold mb-2 text-gray-900 dark:text-white">Místo rezervace:</p>
					{#each selectedSeatsStoreValue as seat, i}
						<p class="text-lg text-gray-700 dark:text-white">
							{i + 1}. Řada {seat.row} - Sedadlo {seat.seatNumber}
						</p>
					{/each}
				</div>
			</div>
		</div>

		<div class="mt-4">
			<div>
				<p class="text-base font-bold text-gray-900 dark:text-white">Způsob doručení:</p>
				<div class="mt-2">
					<label class="inline-flex items-center text-gray-900 dark:text-white">
						<input
							type="radio"
							name="deliveryMethod"
							value="MailTicket"
							checked
							class="text-indigo-600 bg-white border-gray-300 dark:text-indigo-400 dark:bg-gray-800 dark:border-gray-600 focus:ring-indigo-500"
						/>
						<span class="ml-2">Vyzvednutí vstupenek v kině</span>
					</label>
				</div>
			</div>
			<div class="flex items-center space-x-4 mt-4">
				<p class="text-xl font-bold text-gray-900 dark:text-white">Celková cena:</p>
				<p class="text-xl font-bold text-gray-900 dark:text-white">{totalPriceStoreValue} Kč</p>
			</div>
		</div>

		<div class="mt-8">
			<button type="button" on:click="{sendReservation}" class="bg-indigo-600 text-white px-4 py-2 rounded-md">Odeslat rezervaci</button>
		</div>
	{/if}
</div>

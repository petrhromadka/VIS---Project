<script>
	import { createEventDispatcher } from "svelte";

	const dispatch = createEventDispatcher();

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

	function getEventTime(inputDate) {
		const date = new Date(inputDate);

		const hour = date.getHours();
		const minutes = date.getMinutes();

		const formattedTime = `${hour}:${minutes}`;
		return formattedTime;
	}

	function showSeatSelect(movieEv){
		dispatch('eventSelected', {
    		data: {
				eventTime: getEventTime(movieEv.dateTime),
				eventDate: getDateOfEvent(movieEv.dateTime),
				eventHall: movieEv.hall,
				eventPrice: movieEv.price
			}
  		})
	}

	export let events;
</script>

<table class="min-w-full divide-y divide-gray-300">
	<thead>
		<tr>
			<th scope="col" class="py-3.5 pl-4 pr-3 text-left text-sm font-semibold text-gray-900 sm:pl-6"
				>Datum promítání</th
			>
			<th
				scope="col"
				class="hidden px-3 py-3.5 text-center text-sm font-semibold text-gray-900 lg:table-cell"
				>Čas promítání</th
			>
			<th
				scope="col"
				class="hidden px-3 py-3.5 text-center text-sm font-semibold text-gray-900 lg:table-cell"
				>Sál</th
			>
			<th
				scope="col"
				class="hidden lg:table-cell px-3 py-3.5 text-center text-sm font-semibold text-gray-900"
				>Cena</th
			>
			<th scope="col" class="relative py-3.5 pl-3 pr-4 sm:pr-6">
				<span class="sr-only">Koupit vstupenky</span>
			</th>
		</tr>
	</thead>
	<tbody>
		{#each events as movieEvent}
		<tr>
			<td class="relative py-4 pl-4 pr-3 text-sm sm:pl-6">
				<div class="font-medium text-gray-900">
					{getDateOfEvent(movieEvent.dateTime)}
					<span class="font-normal lg:hidden">- {getEventTime(movieEvent.dateTime)}</span>
				</div>
				<div class="mt-1 flex flex-col text-gray-500 sm:block lg:hidden">
					<span>{movieEvent.hall.name}</span>
					<span class="hidden sm:inline">·</span>
					<span>{movieEvent.price} Kč</span>
				</div>
			</td>
			<td class="hidden px-3 py-3.5 text-sm text-center text-gray-500 lg:table-cell">{getEventTime(movieEvent.dateTime)}</td>
			<td class="hidden px-3 py-3.5 text-sm text-center text-gray-500 lg:table-cell">{movieEvent.hall.name}</td>
			<td class="hidden px-3 py-3.5 text-sm text-center text-gray-500 lg:table-cell"
				>{movieEvent.price} Kč</td
			>
			<td class="relative py-3.5 pl-3 pr-4 text-right text-sm font-medium sm:pr-6">
				<button on:click={showSeatSelect(movieEvent)}
					type="button"
					class="inline-flex items-center rounded-md bg-white px-2.5 py-1.5 text-sm font-semibold text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 hover:bg-gray-50 disabled:cursor-not-allowed disabled:opacity-30 disabled:hover:bg-white"
					>Koupit vstupenky
				</button>
			</td>
		</tr>
		{/each}
	</tbody>
</table>

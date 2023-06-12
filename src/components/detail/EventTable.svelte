<script>
	import EventTableRow from './EventTableRow.svelte';

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
			<EventTableRow {movieEvent} />
		{/each}
	</tbody>
</table>

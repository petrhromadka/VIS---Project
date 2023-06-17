<script>
	import { onMount } from 'svelte';
	import { selectedSeats } from '../../stores.js';
	import { onDestroy } from 'svelte';

	onMount(async () => {
		setSeatsListeners();
	});

	let selectedSeatsStoreValue;

	var selectedSeatsUnsubscribe = selectedSeats.subscribe(value => {
		selectedSeatsStoreValue = value;
	})

	//Seats listener
	function setSeatsListeners() {
		var seats = document.getElementsByClassName('seat');

		for (var i = 0; i < seats.length; i++) {
			var seat = seats[i];

			if (!isSeatOccupied(seat)) {
				addClickListener(seat);
			}
		}
	}


	function addClickListener(seat) {
		seat.addEventListener('click', function () {
			if (this.classList.contains('selected')) {
				this.classList.remove('selected');

				var id = this.getAttribute('data-id');
				removeSeatFromSelected(id);
			} 
			
			else {
				this.classList.add('selected');

				var id = this.getAttribute('data-id');
				addSeatToSelected(id);
			}
		});
	}

	function addSeatToSelected(id) {
		var selectedSeat = selectedEvent.hall.seats.find(function (el) {
			return el.id == id;
		});

		var currentSelectedSeats = selectedSeatsStoreValue;
		currentSelectedSeats.push(selectedSeat);

		selectedSeats.update(s => {
			s = currentSelectedSeats;
			return s;
		})
	}

	function removeSeatFromSelected(id) {
		var currentSelectedSeats = selectedSeatsStoreValue;

		var updatedSelectedSeats = currentSelectedSeats.filter(function (el) {
			return !(el.id == id);
		});

		selectedSeats.update(s => {
			s = updatedSelectedSeats;
			return s;
		})
	}

	function isSeatOccupied(seat) {
		return seat.classList.contains('occupied');
	}

	function getRowSeats(arr) {
		const slicedArrays = [];

		for (let i = 0; i < arr.length; i += 10) {
			const slice = arr.slice(i, i + 10);
			slicedArrays.push(slice);
		}

		return slicedArrays;
	}

	onDestroy(() => {
		selectedSeatsUnsubscribe();
	})

	export let selectedEvent;
</script>

<section class="my-16 mx-4">
	<div class="flex items-center flex-col justify-center p-16">
		<div id="seating-plan">
			<div id="screen">Plátno</div>
			{#each getRowSeats(selectedEvent.hall.seats) as row, i}
				<div class="row">
					<div class="row-number">{i + 1}</div>
					{#each row as seat, y}
						<div
							class="seat {seat.isTaken ? 'occupied' : ''}"
							data-id={seat.id}>
							{y + 1}
						</div>
					{/each}
				</div>
			{/each}
		</div>
	</div>
</section>

<style global>
	.seat {
		display: inline-block;
		width: 50px;
		height: 50px;
		border: 1px solid #ccc;
		margin: 5px;
		font-family: Arial, sans-serif;
		font-size: 14px;
		cursor: pointer;

		display: flex;
		align-items: center;
		justify-content: center;
	}

	#seating-plan {
		display: flex;
		flex-direction: column;
		align-items: center;
		justify-content: center;
	}

	#screen {
		width: 100%;
		height: 30px;
		background-color: transparent;
		border: 1px solid #ccc;
		margin-bottom: 10px;

		display: flex;
		align-items: center;
		justify-content: center;
	}

	.row-number {
		display: inline-block;
		width: 30px;
		text-align: center;
		font-family: Arial, sans-serif;
		font-size: 14px;
		margin: 5px;
	}

	.row {
		display: flex;
		align-items: center;
	}

	.occupied {
		background-color: #ff0000;
		color: #ffffff;
	}

	.selected {
		background-color: lightgray;
	}
</style>

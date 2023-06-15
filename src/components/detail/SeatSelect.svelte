<script>
	import { createEventDispatcher } from "svelte";
	import { onMount } from 'svelte';

	const dispatch = createEventDispatcher();

	onMount(async () => {
		var seats = document.getElementsByClassName('seat');
		for (var i = 0; i < seats.length; i++) {
			
			if(seats[i].classList.contains('occupied')){
				continue;
			}

			seats[i].addEventListener('click', function () {
				if(this.classList.contains('selected')){
					this.classList.remove('selected');
					seatCount = seatCount - 1;
				}

				else{
					this.classList.add('selected');
					seatCount = seatCount + 1;
				}

				seatSelected();
			});
		}
	});

	function seatSelected(){
		dispatch('seatSelected', {
    		seatCount: seatCount
  		})
	}

	function getRowSeats(arr){
		arr[0].isTaken = true;
		const slicedArrays = [];

		for (let i = 0; i < arr.length; i += 10) {
		const slice = arr.slice(i, i + 10);
		slicedArrays.push(slice);
		}

		return slicedArrays;
	}

	let seatCount = 0;

	export let selectedEvent;

</script>

<section class="my-16 mx-4">
	<div class="flex items-center flex-col justify-center p-16">
		<div id="seating-plan">
			<div id="screen">Plátno</div>
			{#each getRowSeats(selectedEvent.eventHall.seats) as row, i}
				<div class="row">
					<div class="row-number">{i + 1}</div>
					{#each row as seat, y}
						<div class="seat {seat.isTaken ? 'occupied' : ''}">{y + 1}</div>
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
		max-width: 400px;

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

<script>
  import Badges from '../../../components/Badges.svelte';
  import EventTable from '../../../components/detail/EventTable.svelte';
  import Thumbnail from '../../../components/detail/Thumbnail.svelte';
  import SeatSelect from '../../../components/detail/SeatSelect.svelte';

  function eventSelected(selectedEv){
    selectedEvent = selectedEv;
  }

  function clearStoredProps(){
    selectedEvent = null;
    price = 0;
  }

  let selectedEvent;
  let price = 0;

  export let data;

</script>

<div class="bg-white py-8 sm:py-16">
  <div class="mx-auto max-w-7xl px-6 lg:px-8">
    <div class="mx-auto grid max-w-2xl grid-cols-1 items-start gap-x-8 gap-y-16 sm:gap-y-24 lg:mx-0 lg:max-w-none lg:grid-cols-2">
      <Thumbnail thumbnailUrl={data.thumbnail}/>
      <div>
        <div class="text-base leading-7 text-gray-700 lg:max-w-lg">
          <h1 class="mt-2 text-3xl font-bold tracking-tight text-gray-900 sm:text-4xl">{data.title}</h1>
          <p class="my-2 text-gray-400">Režie: {data.director} • {data.duration} min.</p>
          <Badges rating={data.rating} genre={data.genre}/>
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
    <div class="w-full border-t border-gray-300"></div>
  </div>
  <div class="relative flex justify-center">
  </div>
</div>

<div class="px-4 sm:px-6 lg:px-8 py-8 lg:py-16">
    {#if selectedEvent == null}
      
      <div class="sm:flex sm:items-center">
        <div class="sm:flex-auto">
          <h1 class="text-base font-semibold leading-6 text-gray-900">Seznam promítání</h1>
          <p class="mt-2 text-sm text-gray-700">Vyberte termín promítaní filmu.</p>
        </div>
      </div>
      <div class="-mx-4 mt-10 ring-1 ring-gray-300 sm:mx-0 sm:rounded-lg">
        <EventTable events={data.events} on:eventSelected={(e) => eventSelected(e.detail.data)}/>
      </div>

    {:else}
      <div class="sm:flex sm:items-center">
        <div class="sm:flex-auto">
          <h1 class="text-base font-semibold leading-6 text-gray-900">Rezervace sedadel</h1>
          <p class="mt-2 text-sm text-gray-700">{selectedEvent.eventDate} - {selectedEvent.eventTime} - {selectedEvent.eventHall.name}</p>
        </div>
        <div class="mt-3 flex sm:ml-4 sm:mt-0">
          <p class="mr-4 flex items-center justify-center">Celková cena:  {price} kč</p>
          <button type="button" on:click={() => clearStoredProps()} class="inline-flex items-center rounded-md bg-white px-3 py-2 text-sm font-semibold text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 hover:bg-gray-50">Zpět</button>
          <button type="button" class="ml-3 inline-flex items-center rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600">Hotovo</button>
        </div>
      </div>
      <SeatSelect selectedEvent={selectedEvent} on:seatSelected={(e) => {price = selectedEvent.eventPrice * e.detail.seatCount}}/>
    {/if}

</div>

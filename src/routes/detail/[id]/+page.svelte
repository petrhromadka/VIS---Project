<script>
	import Badges from '../../../components/Badges.svelte';
import EventTable from '../../../components/detail/EventTable.svelte';
import Thumbnail from '../../../components/detail/Thumbnail.svelte';

export let data;

</script>

<div class="bg-white py-8 sm:py-16">
  <div class="mx-auto max-w-7xl px-6 lg:px-8">
    <div class="mx-auto grid max-w-2xl grid-cols-1 items-start gap-x-8 gap-y-16 sm:gap-y-24 lg:mx-0 lg:max-w-none lg:grid-cols-2">
      <Thumbnail thumbnailUrl={data.thumbnail}/>
      <div>
        <div class="text-base leading-7 text-gray-700 lg:max-w-lg">
          <h1 class="mt-2 text-3xl font-bold tracking-tight text-gray-900 sm:text-4xl">{data.title}</h1>
          <Badges rating={data.rating} genre={data.genre}/>
          <div class="max-w-xl">
            <p class="mt-6">Faucibus commodo massa rhoncus, volutpat. Dignissim sed eget risus enim. Mattis mauris semper sed amet vitae sed turpis id. Id dolor praesent donec est. Odio penatibus risus viverra tellus varius sit neque erat velit. Faucibus commodo massa rhoncus, volutpat. Dignissim sed eget risus enim. Mattis mauris semper sed amet vitae sed turpis id.</p>
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
	<div class="sm:flex sm:items-center">
		<div class="sm:flex-auto">
			<h1 class="text-base font-semibold leading-6 text-gray-900">Seznam promítání</h1>
			<p class="mt-2 text-sm text-gray-700">Vyberte termín promítaní filmu.</p>
		</div>
	</div>
	<div class="-mx-4 mt-10 ring-1 ring-gray-300 sm:mx-0 sm:rounded-lg">
    <EventTable events={data.events}/>
	</div>
</div>

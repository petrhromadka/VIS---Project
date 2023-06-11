<svelte:head>
    <title>Contact</title>
    <meta name="description" content="About this app" />
</svelte:head>

<section class="text-gray-600 body-font relative h-screen w-full flex">
    <div class="absolute inset-0 bg-gray-300 ">
        <iframe width="100%" height="100%" frameborder="0" marginheight="0" marginwidth="0" title="mapa" scrolling="no" src="https://maps.google.com/maps?width=100%&amp;height=600&amp;hl=cs&amp;q=Ostrava&amp;ie=UTF8&amp;t=&amp;z=14&amp;iwloc=B&amp;output=embed" style="filter: grayscale(1) contrast(1.2) opacity(0.4);"></iframe>
    </div>
    <div class="container px-5 py-24 mx-auto flex">
        <div class="lg:w-1/4 md:w-1/4 bg-white rounded-lg p-8 flex flex-col md:ml-auto w-full mt-10 md:mt-0 relative z-10 shadow-md">
            <h2 class="text-gray-900 text-lg mb-1 font-medium title-font">Dejte nám Feedback</h2>
            <p class="leading-relaxed mb-5 text-gray-600">Máte problém s lístky?<br><br>Zanechte nám zprávu a my se vám co nejdříve ozveme.</p>
            <a href="mailto:info@example.com?subject=Feedback&body=Prosim, napiste sem vas feedback." class="text-white bg-indigo-500 border-0 py-2 px-6 focus:outline-none hover:bg-indigo-600 rounded text-lg">Napište nám email</a>
            <p class="text-xs text-gray-500 mt-3">CinemaPro sídlem v Ostrava-Centrum</p>
        </div>
    </div>
</section>

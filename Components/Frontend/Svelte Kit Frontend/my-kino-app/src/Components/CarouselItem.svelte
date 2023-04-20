<script>
  export let imageUrl;
  export let caption;
</script>

<style>
  .carousel-item {
    display: none;
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    object-fit: cover;
    opacity: 0.5;
    transition: opacity 1s ease-in-out;
  }

  .caption {
    position: absolute;
    bottom: 0;
    left: 50%;
    transform: translateX(-50%);
    background-color: rgba(0, 0, 0, 0.7);
    color: white;
    padding: 10px;
    width: 100%;
    font-size: 1.2rem;
    text-align: center;
  }
</style>

<div class="carousel-item">
  <img src={imageUrl} alt={caption} />
  <div class="caption">{caption}</div>
</div>

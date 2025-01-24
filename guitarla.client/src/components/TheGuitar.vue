<template>
  <div class="col-md-6 col-lg-4 my-4 row align-items-center">
    <div class="col-4">
      <img class="img-fluid" />
    </div>
    <div class="col-8">
      <h3 class="text-black fs-4 fw-bold text-uppercase"></h3>
      <p></p>
      <p class="fw-black text-primary fs-3"></p>
      <button type="button" class="btn btn-dark w-100">
        Agregar al Carrito
      </button>
    </div>
  </div>
</template>

<script setup lang="ts">
const props = defineProps({
  guitarra: {
    type: Object,
    required: true,
  },
});
</script>

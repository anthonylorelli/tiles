<script lang="ts">
    export let topColor;
    export let rightColor;
    export let bottomColor;
    export let leftColor;
</script>

<style>
    .tile
    {
        width: 0px;
    }
</style>

<div class="tile" style="border: 128px solid {topColor}; border-right-color: {rightColor}; border-bottom-color: {bottomColor}; border-left-color: {leftColor};">
</div>
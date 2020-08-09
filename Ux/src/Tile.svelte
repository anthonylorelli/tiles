<script lang="ts">
    export let size: number = 32;
    export let topColor: string;
    export let rightColor: string;
    export let bottomColor: string;
    export let leftColor: string;
</script>

<style>
    .tile
    {
        width: 0px;
        border-radius: 5px;
    }
</style>

<div class="tile"
    style="border: {size}px solid {topColor};
    border-right-color: {rightColor};
    border-bottom-color: {bottomColor};
    border-left-color: {leftColor};">
</div>
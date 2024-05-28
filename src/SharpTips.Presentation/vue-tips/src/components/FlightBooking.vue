<template>
    <div class="flight-booking">
        <div class="search-bar">
            <input type="text" v-model="from" placeholder="From" />
            <input type="text" v-model="to" placeholder="To" />
            <input type="date" v-model="date" />
            <button @click="searchFlights">
                <i class="fa fa-search"></i>
            </button>
        </div>
        <!-- Add your flight search results here -->
    </div>
</template>

<script setup>
import { ref } from 'vue';

const from = ref('');
const to = ref('');
const date = ref('');

const searchFlights = () => {
    // Implement flight search logic here
};

</script>

<style scoped>
.flight-booking {
    /* Add your custom styles here */
}

.search-bar {
    display: flex;
    align-items: center;
    justify-content: space-between;
    padding: 10px;
    background-color: #f5f5f5;
    border-radius: 5px;
}

input[type='text'],
input[type='date'] {
    padding: 5px;
    border: none;
    outline: none;
    background-color: transparent;
    font-size: 14px;
}

button {
    padding: 5px;
    border: none;
    outline: none;
    background-color: transparent;
    cursor: pointer;
}
</style>
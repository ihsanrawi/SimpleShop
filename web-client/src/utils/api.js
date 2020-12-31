import axios from "axios";

const BASE_URL = "https://localhost:5001/api";

export const getProducts = async () => {
    try {
        return await axios.get(`${BASE_URL}/Products/Products`)
    } catch (error) {
        console.log(error);
    }
}

export const getProduct = async (id) => {
    try {
       return await axios.get(`${BASE_URL}/Products/Product/${id}`)
    } catch (error) {
        console.log(error);
    }
}

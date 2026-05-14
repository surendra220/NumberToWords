import { useState } from "react";

const App = ()=> {
  const [number, setNumber] = useState("");
  const [result, setResult] = useState("");

  const convert = async () => {
    try {
      const res = await fetch(
        `http://localhost:5095/api/numbertowords/Convert?number=${number}`
      );
      const data = await res.text();
      setResult(data);
    } catch (err) {
      setResult(" CORS issue");
    }
  };
  return (
    <div style={{ textAlign: "center", marginTop: "50px" }}>
      <h1>Number To Words</h1>
      <input
        value={number}
        onChange={(e) => setNumber(e.target.value)}
        placeholder="Enter a number"
      />
      <button onClick={convert}>Convert</button>
      <h2>{result}</h2>
    </div>
  );
}
export default App;
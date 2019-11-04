//8kyu: Surface Area and Volume of a Box solution in Javascript

const getSize = (width, height, depth) => {
  const area = (width * depth + depth * height + width * height) * 2
  const volume = width * height * depth
  return [area, volume]
}

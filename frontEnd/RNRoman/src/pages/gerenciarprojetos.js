import React, { Component } from 'react';
import { Text, View, StyleSheet } from 'react-native';

class GerenciarProjetos extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Text>Gerenciar Projetos</Text>
            </View>
        )
    }
}

export default GerenciarProjetos;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});